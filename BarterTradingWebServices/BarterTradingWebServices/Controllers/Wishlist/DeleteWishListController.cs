using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BarterTradingWebServices.Controllers.Wishlist
{
    public class DeleteWishListController : ApiController
    {
        // GET api/deletewishlist
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/deletewishlist/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/deletewishlist
        public void Post([FromBody]string value)
        {
        }

        // PUT api/deletewishlist/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/deletewishlist/5
        public void Delete(int id)
        {
        }
    }
}
