using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class DeleteUserController : ApiController
    {
        // GET api/deleteuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/deleteuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/deleteuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/deleteuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deleteuser/5
        public void Delete(int id)
        {
        }
    }
}
