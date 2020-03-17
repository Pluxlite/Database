using System;

namespace FormUI
{
    public class CarName
    {
        public int CarId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string ShowInfo
        {
            get
            {    
                // Dodge 2003 red
                return $" {Name} {Year} {Color}";
            }
        }
    }
}