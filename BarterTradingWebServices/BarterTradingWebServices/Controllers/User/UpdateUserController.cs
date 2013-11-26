using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class UpdateUserController : ApiController
    {
        // GET api/updateuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/updateuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/updateuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/updateuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updateuser/5
        public void Delete(int id)
        {
        }
    }
}
