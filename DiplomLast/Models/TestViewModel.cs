using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiplomLast.Models
{
    public class TestViewModel
    {
       public string Familya { get; set; }
        public string Name { get; set; }
        public string Fname { get; set; }
        public string IIN { get; set; }
        public decimal? maxPoints { get; set; }
        public decimal? userPoints { get; set; }
        public string maxTimes { get; set; }
        public string userTimes { get; set; }
        public string nameTest { get; set; }
        public DateTime date { get; set; }

    }
}