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


namespace BarterTradingWebServices.Controllers.Utils
{
    public class UploadImageController : ApiController
    {
        [HttpGet]
        public string UploadImage(string token, string base64, string INfileName)
        {
            byte[] imageBytes = Convert.FromBase64String(base64);
            MemoryStream ms = new MemoryStream(imageBytes, 0,imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);




            image.Save("c:\\myBitmap.jpg");





            /*

            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(Microsoft.WindowsAzure.CloudConfigurationManager.GetSetting("StorageConnectionString"));
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();


            storageAccount.CreateCloudBlobClient();
            // Retrieve a reference to a container. 
            CloudBlobContainer container = blobClient.GetContainerReference("bartertrading");
            container.CreateIfNotExists();

            CloudBlockBlob blockBlob = container.GetBlockBlobReference(INfileName);
            // Create or overwrite the "myblob" blob with contents from a local file.
            
            using (var fileStream = System.IO.File.OpenRead(@"path\myfile"))
            {
                blockBlob.UploadFromFile(image, ".JPG");
            }
             * */

            return "dsad";
        }
    }
}
