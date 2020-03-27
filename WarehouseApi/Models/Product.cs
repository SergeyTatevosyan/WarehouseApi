using System;
namespace WarehouseApi.Models
{
    public class Product
    {
        public string Name { get; set; }

        public string VendorСode {get; set;}

        public double Weight { get; set; }

        public double Volume { get; set; }

        public Product(string name, string vendorСode, double weight, double volume)
        {
            Name = name;
            VendorСode = vendorСode;
            Weight = weight;
            Volume = volume;
        }
    }
}
