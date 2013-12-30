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
    public class UpdateUserController : ApiController
    {
        [HttpGet]
        public UserModel UpdateUser(string token, int INuserID, string INemail, string INnickname, string INcontact, string INdob, string INsex, string INimageurl, string INstatus)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = from c in db.USERs
                            where (c.userID == INuserID)
                            select c;
                List<USER> OUTUsers = query.ToList();

                if (token.Equals("token"))
                {
                    if (OUTUsers.Count > 0)
                    {
                        USER user = query.ToList().ElementAt(0);
                        user.email = INemail;
                        user.nickname = INnickname;
                        user.contact = INcontact;
                        user.dob = INdob;
                        user.sex = INsex;
                        user.imageURL = INimageurl;
                        user.status = INstatus;

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
                            model.Message = "Failed to update user";
                            model.Errors = errors;
                            model.Data = null;
                            return model;
                        }
                        else
                        {
                            UserModel model = new UserModel();
                            model.Status = 0;
                            model.Message = "User updated successfullt";
                            model.Errors = errors;
                            model.Data = new List<USER> { user };
                            return model;
                        }
                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "User does not exist";
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
