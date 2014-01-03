using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BarterTradingWebServices.Model;
using System.Data.Entity.Validation;

namespace BarterTradingWebServices.Controllers.Trading
{
    public class SendTradeRequestController : ApiController
    {
        [HttpGet]
        public RequestModel createTrade(string token, int INpOfferID, int INpTakeID, int INuOfferID, int INuTakeID, string INstatus)
        {
            using (BarterTradingDBEntities db = new BarterTradingDBEntities())
            {
                int result = 0;
                List<string> errors = new List<string>();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

                var query = db.TRANSACTIONs;
                List<TRANSACTION> OUTtrade = query.ToList();

                TRANSACTION newTrade = new TRANSACTION();
                newTrade.productOfferID = INpOfferID;
                newTrade.productTakeID = INpTakeID;
                newTrade.userOfferID = INuOfferID;
                newTrade.userTakeID = INuTakeID;
                newTrade.status = INstatus;

                if (token.Equals("token"))
                {
                    query.Add(newTrade);
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
                        RequestModel model = new RequestModel();
                        model.Status = 1;
                        model.Message = "Failed to add trade";
                        model.Errors = errors;
                        model.Data = null;
                        return model;
                    }
                    else
                    {
                        RequestModel model = new RequestModel();
                        model.Status = 0;
                        model.Message = "trade added successfullt";
                        model.Errors = errors;
                        model.Data = new List<TRANSACTION> { newTrade };
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
