using System;
using System.Collections.Generic;
using System.Text;

namespace ChurchSuiteSharp.Models
{
    public class SignupOptions
    {
        public string notification { get; set; }
        public Connect connect { get; set; }
        public Embed embed { get;set; }
        public Public @public { get; set; }
        public string sequence_signup { get; set; }
        public string signup_enabled { get; set; }
        public Tickets tickets { get; set; }
        public List<string> visible_to_tags { get; set; }
    }
}
