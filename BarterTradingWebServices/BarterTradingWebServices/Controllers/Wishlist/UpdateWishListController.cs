using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Wishlist
{
    public class UpdateWishListController : ApiController
    {
        // GET api/updatewishlist
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/updatewishlist/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/updatewishlist
        public void Post([FromBody]string value)
        {
        }

        // PUT api/updatewishlist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/updatewishlist/5
        public void Delete(int id)
        {
        }
    }
}
