using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave2_1
    {
        public void InputMethod()
        {
            Console.Clear();
            string navn = "X", ekstra = "Z";
            int alder = 0;

            //Laver lige en start for at lave sjov med opgave beskrivelsen, men se hvordan jeg skrev Y.
            //Fordi int kan ikke være et bogstav.
            Console.WriteLine("Dit navn er {0}, du er Y år gammel og {1}", navn, ekstra);
            Console.Write("Indsæt navn: ");
            navn = Console.ReadLine();
            Console.Write("Insæt alder: ");
            alder = Convert.ToInt32(Console.ReadLine());
            
            OutputMethod(navn, alder, ekstra);
        }
        void OutputMethod(string navn, int alder, string ekstra)
        {
            if (alder == 1)
            {
                ekstra = "du er lige født";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (alder >= 2 && alder <= 5)
            {
                ekstra = "du kan begynde i børnehave";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (alder >= 6 && alder <= 16)
            {
                ekstra = "du går i skole";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (alder > 16)
            {
                ekstra = "nu begynder alvoren";
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.WriteLine("Noget gik galt");
                return;
            }
            Console.WriteLine("Dit navn er {0}, du er {1} år gammel og {2}", navn, alder, ekstra);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
