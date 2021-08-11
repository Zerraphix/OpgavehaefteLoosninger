using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave2_3
    {
        public void InputMethod()
        {
            Console.Clear();
            int alder, karakter;
            Console.Write("Indsæt alder: ");
            alder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indsæt karakter: ");
            karakter = Convert.ToInt32(Console.ReadLine());

            OutputMethod(alder, karakter);
        }
        void OutputMethod(int alder, int karakter)
        {
            //Her har vi en masse if og else if kommandoer for at styre alder og karakter sammen.
            //Har også nogle fejl skrifter fordi opgaven ikke skriver over nogle af værdierne.
            if (alder >= 18 && alder <= 24)
            {
                if (karakter >= 1 && karakter <= 4)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (karakter >= 5 && karakter <= 9)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (karakter >= 10 && karakter <= 13)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("Fejl");
                    return;
                }
            }
            else if (alder >= 25 && alder <= 29)
            {
                if (karakter >= 1 && karakter <= 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else if (karakter >= 6 && karakter <= 10)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (karakter >= 11 && karakter <= 13)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.WriteLine("Fejl");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Fejl");
                return;
            }
            Console.WriteLine("Alder Karakter");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ReadKey();
        }
    }
}
