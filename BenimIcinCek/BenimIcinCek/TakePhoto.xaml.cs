using System;
using System.IO;
using System.Net;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using BenimIcinCek.ImageService;
using Microsoft.Devices;

namespace BenimIcinCek
{
    public partial class TakePhoto
    {
        public TakePhoto()
        {
            InitializeComponent();

            CameraButtons.ShutterKeyHalfPressed += (sender, args) => _camera.Focus();

            CameraButtons.ShutterKeyPressed += (sender, args) => _camera.CaptureImage();
        }

        private readonly PhotoCamera _camera = new PhotoCamera(CameraType.Primary);
        private string _connectionID = string.Empty;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var rawUri = HttpUtility.UrlDecode(e.Uri.OriginalString);
            _connectionID = rawUri.Substring(rawUri.LastIndexOf("?", StringComparison.InvariantCulture) + 1);

            _camera.CaptureImageAvailable += (sender, args) => Dispatcher.BeginInvoke(() =>
            {
                var image = new BitmapImage();
                image.SetSource(args.ImageStream);

                var bitmap = new WriteableBitmap(image);
                var ms = new MemoryStream();
                bitmap.SaveJpeg(ms, 200, 120, 0, 100);
                SendPhotoToCloud(ms.ToArray());
            });

            viewfinderBrush.SetSource(_camera);
        }

        private void SendPhotoToCloud(byte[] image)
        {
            var client = new ImageClient();

            client.UploadCompleted += (sender, args) => App.Proxy.Invoke("SendImageToDevice", _connectionID, args.Result);

            client.UploadAsync(image);
        }

        private void ViewfinderCanvas_OnTap(object sender, GestureEventArgs e)
        {
            _camera.CaptureImage();
        }
    }
}