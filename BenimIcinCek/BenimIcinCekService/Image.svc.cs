using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace BenimIcinCekService
{
    [ServiceContract]
    public class Image
    {
        [OperationContract]
        public string Upload(byte[] image)
        {
            var fileName = Guid.NewGuid().ToString("N").Substring(0, 4) + DateTime.Now.Ticks + ".jpg";

            MemoryData.ImageList.Add(fileName, image);

            return fileName;
        }

        [OperationContract]
        public byte[] Download(string fileName)
        {
            if (MemoryData.ImageList.ContainsKey(fileName))
            {
                return MemoryData.ImageList[fileName];
            }

            return null;
        }
    }

    public static class MemoryData
    {
        public static Dictionary<string, byte[]> ImageList = new Dictionary<string, byte[]>();
    }
}
