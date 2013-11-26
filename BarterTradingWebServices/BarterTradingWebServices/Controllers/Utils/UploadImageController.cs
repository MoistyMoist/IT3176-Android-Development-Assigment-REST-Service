using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Utils
{
    public class UploadImageController : ApiController
    {
        // GET api/uploadimage
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/uploadimage/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/uploadimage
        public void Post([FromBody]string value)
        {
        }

        // PUT api/uploadimage/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/uploadimage/5
        public void Delete(int id)
        {
        }
    }
}
