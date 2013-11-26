using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Trading
{
    public class AcceptTradeRequestController : ApiController
    {
        // GET api/accepttraderequest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/accepttraderequest/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/accepttraderequest
        public void Post([FromBody]string value)
        {
        }

        // PUT api/accepttraderequest/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/accepttraderequest/5
        public void Delete(int id)
        {
        }
    }
}
