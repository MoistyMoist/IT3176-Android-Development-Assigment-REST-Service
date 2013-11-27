using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class SearchProductController : ApiController
    {
       [HttpGet]
       public ProductModel searchProduct(string token, string INkey)
       {
           using (BarterTradingDBEntities db = new BarterTradingDBEntities())
           {
               db.Configuration.LazyLoadingEnabled = false;

               var query = from c in db.PRODUCTs.Include("User")
                           where (c.status == 0&&(c.description.Contains(INkey)||c.name.Contains(INkey)||c.quality.Contains(INkey)))
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
