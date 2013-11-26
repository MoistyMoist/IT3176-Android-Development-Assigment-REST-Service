using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Product
{
    public class UpdateProductController : ApiController
    {
        // GET api/updateproduct
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/updateproduct/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/updateproduct
        public void Post([FromBody]string value)
        {
        }

        // PUT api/updateproduct/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updateproduct/5
        public void Delete(int id)
        {
        }
    }
}
