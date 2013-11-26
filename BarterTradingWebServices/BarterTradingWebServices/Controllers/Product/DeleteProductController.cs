using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.Validation;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Product
{
    public class DeleteProductController : ApiController
    {
        [HttpGet]
        public ProductModel removeProduct(string token, int INproductID)
        {
            using (BarterTradingDBEntities db= new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = from c in db.PRODUCTs
                            where (c.productID == INproductID)
                            select c;

                List<PRODUCT> OUTProducts = query.ToList();

                if (token.Equals("token"))
                {
                    if (OUTProducts.Count > 0)
                    {
                        PRODUCT product = query.ToList().ElementAt(0);
                        product.status = 2;

                        try
                        {
                            result = db.SaveChanges();
                        }
                        catch (DbEntityValidationException dbEx)
                        {
                            result = 0;
                            foreach (var validationErrors in dbEx.EntityValidationErrors)
                            {
                                foreach (var validationError in validationErrors.ValidationErrors)
                                {
                                    string error = "Property: " + validationError.PropertyName + "Error: " + validationError.ErrorMessage;
                                    errors.Add(error);
                                    System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                                }
                            }
                        }
                        if (result == 0)
                        {
                            ProductModel model = new ProductModel();
                            model.Status = 1;
                            model.Message = "Failed to delete product";
                            model.Errors = errors;
                            model.Data = null;
                            return model;
                        }
                        else
                        {
                            ProductModel model = new ProductModel();
                            model.Status = 0;
                            model.Message = "Product deleted successfullt";
                            model.Errors = errors;
                            model.Data = new List<PRODUCT> { product };
                            return model;
                        }
                    }
                    else
                    {
                        ProductModel model = new ProductModel();
                        model.Status = 1;
                        model.Message = "Product does not exist";
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
