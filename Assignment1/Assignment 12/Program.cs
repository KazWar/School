using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            char[] characters = { 'A', 'B', 'C', 'a', 'b', 'c', '0', '1', '2', '$', '+', '/' };
            List<int> enteredCharacters = new List<int>();
            
            Console.Write("Example of Characters to integers: \n");
            foreach (var i in characters)
            {
                var intCharacter = (int)i;
                Console.WriteLine("{0} = {1}", i, intCharacter);
            }

            Console.WriteLine("\nWrite down keyboard characters. Press escape to stop typing.");

            ConsoleKey myKey;
            do {
                myKey = Console.ReadKey().Key;
                if (myKey == ConsoleKey.Enter)
                {
                    enteredCharacters.Add((int)myKey);
                } else {
                    character = Convert.ToChar(myKey);
                    enteredCharacters.Add(character);
                }
            } while (!(ConsoleKey.Escape.Equals(myKey)));

            Console.WriteLine("\nEntered characters are: ");
            foreach (var i in enteredCharacters)
            {
                Console.WriteLine("{0} = {1}", i, Convert.ToChar(i));
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
