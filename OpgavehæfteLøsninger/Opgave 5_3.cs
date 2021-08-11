using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave5_3
    {
        public void TextMethod()
        {
            Console.Clear();
            Console.WriteLine("*** Color text duplicate thing machine ***");
            Console.WriteLine("Welcome, here we will write the same text in 2 different colors 20 times.");
            Console.WriteLine("Trick is that I am only using one writeline.");
            Console.WriteLine("Press any button to begin.");
            Console.ReadKey();

            for (int i = 1; i <= 20; i++)
            {
                //Looks for even numbers
                if (i%2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine("Tekst med farve.");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
