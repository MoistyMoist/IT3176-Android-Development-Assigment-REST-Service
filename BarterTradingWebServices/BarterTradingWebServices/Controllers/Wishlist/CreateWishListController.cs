using BarterTradingWebServices.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Wishlist
{
    public class CreateWishListController : ApiController
    {
        [HttpGet]
        public WishlistModel createWishlist(string token, int INuserID, string INname, string INstatus)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = db.WISHes;
                List<WISH> OUTWishes = query.ToList();

                WISH newWish = new WISH();
                newWish.name = INname;
                newWish.status = INstatus;
                newWish.userID = INuserID;

                if (token.Equals("token"))
                {
                    query.Add(newWish);
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
                        WishlistModel model = new WishlistModel();
                        model.Status = 1;
                        model.Message = "Failed to add product";
                        model.Errors = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        WishlistModel model = new WishlistModel();
                        model.Status = 0;
                        model.Message = "Product added successfullt";
                        model.Errors = errors;
                        model.Data = new List<WISH> { newWish };
                        return model;
                    }
                }
                else
                {
                    WishlistModel model = new WishlistModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
    }
}
