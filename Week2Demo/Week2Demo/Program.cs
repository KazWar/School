using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare some variable I need
            string userName = "";   // do you have any idea what happens here?
            int userAge = 0;        // or here?
            int opA, opB;

            // say hello
            Console.WriteLine("Hello there!");

            // ask the user's name
            Console.Write("What is your name? ");
            userName = Console.ReadLine();

            // ask age
            Console.Write("Hi {0}, what is your age? ",userName);
            userAge = Convert.ToInt32(Console.ReadLine());

            // depending on what age group he/she is in do stuff
            if (userAge < 0)
            {
                // input is not possible so tell him
                Console.WriteLine("That is impossible, you're not born yet....");
            }
            else
            {
                if (userAge < 10)
                {
                    // tell the user is a bit young
                    Console.WriteLine("\nYou're a bit young, just a kid...");
                }
                else
                {
                    // do a little game
                    Console.WriteLine("\nAah, you're old enough to play a little game:");

                    Console.Write("Enter a whole number please (A) : ");
                    opA = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter another whole number please (B) : ");
                    opB = Convert.ToInt32(Console.ReadLine());

                    // let's do some math
                    Console.WriteLine("{0} + {1} = {2}", opA, opB, opA + opB);
                    Console.WriteLine("{0} - {1} = {2}", opA, opB, opA - opB);
                    Console.WriteLine("{0} * {1} = {2}", opA, opB, opA * opB);
                    Console.WriteLine("{0} % {1} = {2}", opA, opB, opA % opB);
                    Console.WriteLine("{0} / {1} = {2}", opA, opB, opA / opB);

                }
            }

            // and wait for the any-key
            Console.ReadKey();
        }
    }
}
