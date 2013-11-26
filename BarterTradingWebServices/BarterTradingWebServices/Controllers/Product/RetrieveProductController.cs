using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Product
{
    public class RetrieveProductController : ApiController
    {
        // GET api/retrieveproduct
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrieveproduct/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrieveproduct
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrieveproduct/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrieveproduct/5
        public void Delete(int id)
        {
        }
    }
}
