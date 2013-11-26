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
    public class CreateProductController : ApiController
    {
        [HttpGet]
        public ProductModel createProduct(string token,int INuserID, string INname, string INdescription, string INqty, string INstatus, string INx, string INy, string INquality, string INimageURL)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = db.PRODUCTs;
                List<PRODUCT> OUTProducts = query.ToList();

                PRODUCT newProduct = new PRODUCT();
                newProduct.name = INname;
                newProduct.description = INdescription;
                newProduct.qty = INqty;
                newProduct.quality = INquality;
                newProduct.x = INx;
                newProduct.y = INy;
                newProduct.imageURL = INimageURL;
                newProduct.status = 0;
                newProduct.userID = INuserID;
               
                if(token.Equals("token"))
                {
                    query.Add(newProduct);
                    try
                    {
                        result = db.SaveChanges();
                    }
                    catch(DbEntityValidationException dbEx)
                    {
                        result = 0;
                        foreach(var validationErrors in dbEx.EntityValidationErrors)
                        {
                            foreach(var validationError in validationErrors.ValidationErrors)
                            {
                                string error = "Property: " + validationError.PropertyName + "Error: " + validationError.ErrorMessage;
                                errors.Add(error);
                                System.Diagnostics.Debug.WriteLine("Property: {0} Error: {1}",validationError.PropertyName,validationError.ErrorMessage);
                            }
                        }
                    }
                    if(result==0)
                    {
                        ProductModel model = new ProductModel();
                        model.Status = 1;
                        model.Message = "Failed to add product";
                        model.Errors = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        ProductModel model = new ProductModel();
                        model.Status = 0;
                        model.Message = "Product added successfullt";
                        model.Errors = errors;
                        model.Data = new List<PRODUCT> { newProduct };
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
