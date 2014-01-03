using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;

namespace BarterTradingWebServices.Controllers.Trading
{
    public class RetrieveTransactionController : ApiController
    {
        [HttpGet]
        public RequestModel getTradeTaker(string token, int userID)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;

                var query = from c in db.TRANSACTIONs
                            where (c.userTakeID.Equals(userID))
                            select c;
                List<TRANSACTION> OUTtrade = query.ToList();
                if (token.Equals("token"))
                {
                    if (OUTtrade.Count() == 0)
                    {
                        RequestModel model = new RequestModel();
                        model.Status = 1;
                        model.Message = "Error retrieveing trade";
                        return model;
                    }
                    else
                    {
                        RequestModel model = new RequestModel();
                        model.Status = 0;
                        model.Message = "Retrieve success";
                        model.Data = OUTtrade;
                        return model;
                    }
                }
                else
                {
                    RequestModel model = new RequestModel();
                    model.Status = 1;
                    model.Message = "Token error, invalid token";
                    return model;
                }
            }
        }
    }
}
