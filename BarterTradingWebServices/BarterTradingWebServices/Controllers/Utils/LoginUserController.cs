using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Utils
{
    public class LoginUserController : ApiController
    {
        // GET api/loginuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/loginuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/loginuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/loginuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/loginuser/5
        public void Delete(int id)
        {
        }
    }
}
