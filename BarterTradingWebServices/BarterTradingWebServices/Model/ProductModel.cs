using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarterTradingWebServices.Model
{
    public class ProductModel
    {
        public string message { get; set; }
        public string status { get; set; }
        public List<PRODUCT> data { get; set; }
        public List<string> errors { get; set; }
    }
}