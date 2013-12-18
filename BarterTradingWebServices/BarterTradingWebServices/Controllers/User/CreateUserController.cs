using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class CreateUserController : ApiController
    {

        /*
        [HttpGet]
        public UserModel createProduct(string token, string password, string nickname, string email, string contact, string dob, string sex, string imageURL string status)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = db.PRODUCTs;
                List<PRODUCT> OUTProducts = query.ToList();

                USER newUser = new USER();
                newUser.password = ;
                newUser.description = INdescription;
                newUser.qty = INqty;
                newUser.quality = INquality;
                newUser.x = INx;
                newProduct.y = INy;
                newProduct.imageURL = INimageURL;
                newProduct.status = 0;
                newProduct.userID = INuserID;

                if (token.Equals("token"))
                {
                    query.Add(newProduct);
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
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "Failed to add product";
                        model.Errors = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 0;
                        model.Message = "Product added successfullt";
                        model.Errors = errors;
                        model.Data = new List<USER> { newProduct };
                        return model;
                    }
                }
                else
                {
                    UserModel model = new UserModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        } **/
    }
}
