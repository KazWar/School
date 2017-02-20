using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTable
{
    public class @whileMethod
    {
        public static void whileLoop()
        {
            int index, mtable, outcome;

            //Ask for multiplication table number and convert it to an integer.
            Console.WriteLine("This is the multiplication table using the WHILE method.");
            Console.WriteLine("What table do you want to see?");
            mtable = Convert.ToInt32(Console.ReadLine());

            index = 1;
            while (index <= 10)
            {
                //Calculate the outcome and display the data.
                outcome = index * mtable;
                Console.WriteLine("{0} x {1} = {2}", mtable, index, outcome);
                //Loop the index and add 1 as long as the index is equal or lower than 10.
                index++;
            }
        }
    }
}
