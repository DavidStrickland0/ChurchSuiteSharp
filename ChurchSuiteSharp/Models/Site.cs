namespace ChurchSuiteSharp.Models
{
    public class Site
    {
        public int id { get; set; }
        public string name { get; set; }
        public string color { get; set; }
        public string initials { get; set; }
        public string order { get; set; }
        public Address address { get; set; }
        }
}