using System;
using System.Windows;
using Windows.Networking.Proximity;

namespace BenimIcinCek
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TakePicture_OnClick(object sender, RoutedEventArgs e)
        {
            BackgroundBrush.Opacity = 1;

            var device = ProximityDevice.GetDefault();

            if (device != null)
            {
                long messageID = 0;

                device.DeviceDeparted += (s) =>
                {
                    device.StopPublishingMessage(messageID);
                };

                messageID = device.PublishUriMessage(new Uri("polatengin-benimicincek:?" + App.ConnectionID, UriKind.Absolute));
            }
        }
    }
}