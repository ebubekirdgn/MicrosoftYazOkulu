using System;
using System.Net;
using System.Windows.Navigation;

namespace BenimIcinCek
{
    public class BenimIcinCekUriMapper : UriMapperBase
    {
        public override Uri MapUri(Uri uri)
        {
            var tempUri = HttpUtility.UrlDecode(uri.ToString());

            if (tempUri.Contains("polatengin-benimicincek:"))
            {
                return new Uri("/TakePhoto.xaml", UriKind.Relative);
            }

            return uri;
        }
    }
}