using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static List<Product> listOfProducts;
        static void Main(string[] args)
        {

            int choice;
            int boughtAmount;
            listOfProducts = new List<Product> {
                new Product("Sofa", 1500, 4),
                new Product("Chair", 90, 20),
                new Product("Table", 150, 10),
                new Product("Bed", 120, 5),
                new Product("Wardrobe", 300, 9)
                };

            showProductInformation();

            do
            {
                Console.WriteLine("\nWrite -1 to stop buying.");
                Console.Write("Which product do you want to buy?: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice >= 0 && choice < listOfProducts.Count()) { 
                    Console.Write("How much do you want to buy?: ");
                    boughtAmount = Convert.ToInt32(Console.ReadLine());
                    listOfProducts[choice].SellOneProduct(boughtAmount);
                } else
                {
                    Console.WriteLine("Please enter a product numer from the list below");
                    showProductInformation();
                }
            } while (choice >= 0);

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }

        static void showProductInformation()
        {
            Console.WriteLine("The following products are availible.");
            foreach (var product in listOfProducts)
            {
                Console.WriteLine("|Product #|{0,2}  |Name|{1,10}  |Price|{2,10}  |Stock|{3,10}", listOfProducts.IndexOf(product), product.ProductName, product.PricePP, product.InStock);
            }
        }
    }
}

