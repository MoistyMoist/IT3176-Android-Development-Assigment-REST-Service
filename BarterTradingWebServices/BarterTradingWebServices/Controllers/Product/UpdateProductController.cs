using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class UpdateProductController : ApiController
    {
        [HttpGet]
        public ProductModel UpdateProduct(string token,string INid, string INname, string INdescription, string INqty, string INstatus, string INx, string INy, string INquality, string INimageURL)
        {
            return null;
        }
    }
}
