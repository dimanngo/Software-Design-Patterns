using System.Collections.Generic;

namespace FactoryMethodPattern.ProductBase
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public int Doors { get; set; }
        public List<string> Accessories = new List<string>();

        public abstract void ShowInfo();
    }
}
