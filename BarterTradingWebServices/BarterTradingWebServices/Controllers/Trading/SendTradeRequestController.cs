using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Trading
{
    public class SendTradeRequestController : ApiController
    {
        // GET api/sendtraderequest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/sendtraderequest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/sendtraderequest
        public void Post([FromBody]string value)
        {
        }

        // PUT api/sendtraderequest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sendtraderequest/5
        public void Delete(int id)
        {
        }
    }
}
