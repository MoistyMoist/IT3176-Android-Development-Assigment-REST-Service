using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class CreateProductController : ApiController
    {
        [HttpGet]
        public ProductModel createProduct(string token, string INname, string INdescription, string INqty, string INstatus, string INx, string INy, string INquality, string INimageURL)
        {
            return null;           
        }
    }
}
