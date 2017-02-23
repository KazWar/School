using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal PricePP { get; set; }
        public int InStock { get; set; }

        public Product(string productName, decimal pricePP, int inStock)
        {
            ProductName = productName;
            PricePP = pricePP;
            InStock = inStock;
        }

        public void SellOneProduct(int loopAmount)
        {
            if (InStock >= 0)
            {
                for (int i = 0; i < loopAmount; i++)
                {
                    if (InStock < 10)
                    {
                        InStock -= 1;
                        Console.WriteLine("The product {0}, costs {1} per piece and there are {2} left in stock. Price per piece was discounted by {3}.", ProductName, PricePP - SetDiscountPrice(), InStock, SetDiscountPrice());
                    } else {
                        InStock -= 1;
                        Console.WriteLine("The product {0}, costs {1} per piece and there are {2} left in stock.", ProductName, PricePP, InStock);
                    }
                }
            } else {
                Console.WriteLine("This product is out of stock.");
            }
        }

        public decimal SetDiscountPrice()
        {
            decimal discount = 0;
            if (PricePP >= 10)
            {
                discount = (PricePP * 0.10m);
            }
            return discount;
        }

    }
}
