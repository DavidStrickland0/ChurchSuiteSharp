using Newtonsoft.Json;
using System.Collections.Generic;

namespace ChurchSuiteSharp.Models
{
    public class SmallGroup
    {
        public Cluster cluster { get; set; }
        public int connect_signup { get; set; }
        public int connect_visible { get; set; }
        public CustomField custom_fields { get; set; }
        public string custom_frequency { get; set; }
        public string date_end { get; set; }
        public string date_start { get; set; }
        public string day { get; set; }
        public string description { get; set; }
        public string embed_signup { get; set; }
        public string embed_signup_page_message { get; set; }
        public string embed_signup_page_title { get; set; }
        public string embed_visible { get; set; }
        public string frequency { get; set; }
        public string id { get; set; }
        public string identifier { get; set; }
        public Images images { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public string no_members { get; set; }
        public string public_signup { get; set; }
        public string public_visible { get; set; }
        public string reference { get; set; }
        public string signup_capacity { get; set; }
        public string signup_confirm_email { get; set; }
        public string signup_confirm_email_body { get; set; }
        public string signup_confirm_email_from_email { get; set; }
        public string signup_confirm_email_from_name { get; set; }
        public string signup_confirm_email_subject { get; set; }
        public string signup_date_end { get; set; }
        public string signup_date_start { get; set; }
        public string signup_enabled { get; set; }
        public string signup_full { get; set; }
        public string signup_link_visible { get; set; }
        public string signup_member_status { get; set; }
        public Site site { get; set; }
        public string time { get; set; }

    }
}