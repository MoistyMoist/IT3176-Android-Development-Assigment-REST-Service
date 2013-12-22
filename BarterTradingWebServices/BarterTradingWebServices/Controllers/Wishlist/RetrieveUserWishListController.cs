using BarterTradingWebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Wishlist
{
    public class RetrieveUserWishListController : ApiController
    {
        [HttpGet]
        public WishlistModel GetUserWishlist(string token, int userId)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = from c in db.WISHes
                            where c.userID == userId
                            select c;
                List<WISH> OUTWish = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTWish.Count() == 0)
                    {
                        WishlistModel model = new WishlistModel();
                        model.Status = 1;
                        model.Message = "Error retrieveing products";
                        return model;
                    }
                    else
                    {
                        WishlistModel model = new WishlistModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTWish;
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
