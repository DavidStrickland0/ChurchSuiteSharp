using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchSuiteSharp.Models
{
    public class Calendar
    {
        public string id { get; set; }
        public string identifier { get; set; }
        public string sequence { get; set; }
        public string name { get; set; }
        public DateTime datetime_start { get; set; }
        public DateTime datetime_end { get; set; }
        public string description { get; set; }
        public Category category { get; set; }
        public Brand brand { get; set; }
        public string capacity { get; set; }
        public object images { get; set; }
        public Location location { get; set; }
        public SignupOptions signup_options{get;set;}
        public Site site { get; set; }
    }
}
