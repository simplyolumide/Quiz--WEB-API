﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz_API.Models
{
    public class OnlineexamClass
    {
        public int Qid { get; set; }
        public string Question { get; set; }

        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string corrans { get; set; }



    }
}