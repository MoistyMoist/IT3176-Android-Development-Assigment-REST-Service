﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.User
{
    public class RetrieveUserController : ApiController
    {
        // GET api/retrieveuser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/retrieveuser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/retrieveuser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/retrieveuser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/retrieveuser/5
        public void Delete(int id)
        {
        }
    }
}
