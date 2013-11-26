﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarterTradingWebServices.Model
{
    public class UserModel
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public List<USER> Data { get; set; }
        public List<string> Errors { get; set; }
    }
}