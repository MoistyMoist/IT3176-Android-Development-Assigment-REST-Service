using BarterTradingWebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class RetrieveUserController : ApiController
    {
        [HttpGet]
        public UserModel GetUserByEmail(string token, string email)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = from c in db.USERs
                            where (c.email.Equals(email))
                            select c;
                List<USER> OUTUser = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTUser.Count() == 0)
                    {
                        UserModel model = new UserModel();
                        model.Status = 1;
                        model.Message = "Error retrieveing products";
                        return model;
                    }
                    else
                    {
                        UserModel model = new UserModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTUser;
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
