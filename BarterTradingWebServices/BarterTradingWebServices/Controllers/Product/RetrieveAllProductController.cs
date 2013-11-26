using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class RetrieveAllProductController : ApiController
    {
        [HttpGet]
        public ProductModel GetAllProducts(string token)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = from c in db.PRODUCTs.Include("User")
                            where c.status==0
                            select c;
                List<PRODUCT> OUTProducts = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTProducts.Count() == 0)
                    {
                        ProductModel model = new ProductModel();
                        model.Status = 1;
                        model.Message = "Error retrieveing products";
                        return model;
                    }
                    else
                    {
                        ProductModel model = new ProductModel();
                        model.Status = 1;
                        model.Message = "Retrieve success";
                        model.Data = OUTProducts;
                        return model;
                    }
                }
                else
                {
                    ProductModel model = new ProductModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }

    }
}
