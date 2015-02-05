using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimeDataWebApi.Models
{
    public class Crime
    {
        public int id { get; set; }
        public string murderer { get; set; }
        public string victim { get; set; }
        public DateTime time { get; set; }
        public string category { get; set; }

    }

}