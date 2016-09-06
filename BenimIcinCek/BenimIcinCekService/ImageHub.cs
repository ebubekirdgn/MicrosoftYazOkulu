using Microsoft.AspNet.SignalR;

namespace BenimIcinCekService
{
    public class ImageHub : Hub
    {
        public void SendImageToDevice(string connectionID, string fileName)
        {
            Clients.Client(connectionID).saveImageToLibrary(fileName);
        }
    }
}