using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class DeleteControllerController : ApiController
    {
        [HttpGet]
        public ProductModel removeProduct(string token, string id)
        {
            using (BarterTradingDBEntities db= new BarterTradingDBEntities())
            {
                
            }
            return null;
        }
    }
}
