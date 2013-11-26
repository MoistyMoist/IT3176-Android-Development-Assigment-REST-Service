using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Product
{
    public class CreateProductController : ApiController
    {
        // GET api/createproduct
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/createproduct/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/createproduct
        public void Post([FromBody]string value)
        {
        }

        // PUT api/createproduct/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/createproduct/5
        public void Delete(int id)
        {
        }
    }
}
