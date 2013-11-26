using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class RetrieveProductController : ApiController
    {
        [HttpGet]
        public ProductModel GetAllProducts(string token)
        {
            return null;
        }

        [HttpGet]
        public ProductModel GetProductByID(string token, string id)
        {
            return null;
        }
    }
}
