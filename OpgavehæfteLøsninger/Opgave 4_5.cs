using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave4_5
    {
        public void InputMethod()
        {
            string str = "Forsæt";
            int tæller = 0;
            do
            {
                Console.WriteLine("*** Skrive tester ***");
                Console.WriteLine("I denne maskine skal du finde ud af ordet for at få den til at stoppe.");
                Console.WriteLine("Held og lykke!");
                str = Console.ReadLine();
                tæller++;
            }
            while (str == "Stop");

            OutputMethod(tæller);
        }
        void OutputMethod(int Forsøg)
        {
            Console.WriteLine("Du skrev 'Stop' forkert {0} gange", Forsøg);
        }
    }
}
