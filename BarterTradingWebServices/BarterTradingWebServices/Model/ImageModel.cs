using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarterTradingWebServices.Model
{
    public class ImageModel
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public string Data { get; set; }
        public List<string> Errors { get; set; }
    }
}