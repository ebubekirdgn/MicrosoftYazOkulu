using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using BenimIcinCek.ImageService;
using Microsoft.Xna.Framework.Media;

namespace BenimIcinCek
{
    internal class Global
    {
        public static void SaveImageToLibrary(string fileName)
        {
            var context = new ImageClient();

            context.DownloadCompleted += (sender, args) =>
            {
                var stream = new MemoryStream(args.Result);
                stream.Seek(0, SeekOrigin.Begin);
                //var bitmapImage = new BitmapImage();
                //bitmapImage.SetSource(stream);

                var library = new MediaLibrary();
                library.SavePicture(DateTime.Now.Ticks + ".jpg", stream);
            };

            context.DownloadAsync(fileName);
        }
    }
}