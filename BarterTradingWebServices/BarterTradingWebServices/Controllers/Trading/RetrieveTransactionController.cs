using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Trading
{
    public class RetrieveTransactionController : ApiController
    {
        // GET api/retrievetransaction
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrievetransaction/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrievetransaction
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrievetransaction/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrievetransaction/5
        public void Delete(int id)
        {
        }
    }
}
