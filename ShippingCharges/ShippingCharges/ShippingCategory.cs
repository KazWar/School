using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCharges
{
    class ShippingCategory
    {
        private string v1;
        private int v2;
        private int v3;
        private double v4;
        private int v5;

        public string CategoryName { get; set; }
        public decimal PricePerKm { get; set; }
        public int MaxNumberPackages { get; set; }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public int TotalNumberOfPackages { get; set; }
        public int TotalDistance { get; set; }
        public decimal TotalPrice { get; set; }
        public int MinDistance { get; set; }
        public int MaxDistance { get; set; }

        public ShippingCategory()
        {
        }

        public ShippingCategory(string categoryName, double maxWeight,double minWeight, decimal pricePerKm, int maxNumberPackages)
        {
            if (maxWeight < 0)
                throw new ArgumentException("Invalid minimal weight");
            if (maxWeight < 0)
                throw new ArgumentException("Invalid maximal weight");
            if (maxWeight < minWeight)
                throw new ArgumentException("Maximal weight cannot be less than minimal weight");
            CategoryName = categoryName;
            MaxWeight = maxWeight;
            MinWeight = minWeight;
            PricePerKm = pricePerKm;
            MaxNumberPackages = maxNumberPackages;
        }
    }
}
