using BarterTradingWebServices.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class CreateUserController : ApiController
    {
        [HttpGet]
        public UserModel createUser(string token, string INemail, string INpassword, string INnickname, string INcontact, string INdob, string INsex, string INimageurl, string INstatus)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = db.USERs;
                List<USER> OUTUser = query.ToList();

                USER newUser = new USER();
                newUser.email = INemail;
                newUser.password = INpassword;
                newUser.nickname = INnickname;
                newUser.contact = INcontact;
                newUser.dob = INdob;
                newUser.sex = INsex;
                newUser.imageURL = INimageurl;
                newUser.status = INstatus;

                if (token.Equals("token"))
                {
                    query.Add(newUser);
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
                        model.Message = "User added successfullt";
                        model.Errors = errors;
                        model.Data = new List<USER> { newUser };
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
        }
    }
}
