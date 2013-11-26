using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class CreateUserController : ApiController
    {
        // GET api/createuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/createuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/createuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/createuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/createuser/5
        public void Delete(int id)
        {
        }
    }
}
