using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Configuration;
using System.IO;
using System.Drawing;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Utils
{
    public class UploadImageController : ApiController
    {
        [HttpPost]
        public ImageModel postTest([FromBody] string base64)
        {
                DateTime date = DateTime.Now;
                string fileName = date.ToString();

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.WindowsAzure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            storageAccount.CreateCloudBlobClient();
            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("bartertrading");
            container.CreateIfNotExists();

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileName);

            byte[] bytes = Convert.FromBase64String(base64);

            using (var stream = new MemoryStream(bytes))
            {
                blockBlob.UploadFromStream(stream);
            }

            string url = "http://114173s.blob.core.windows.net/bartertrading/" + fileName;

            ImageModel model = new ImageModel();
            model.Data = url;
            model.Message = base64.Length.ToString();
            model.Status = 1;
            return model;
        }
    }
}
