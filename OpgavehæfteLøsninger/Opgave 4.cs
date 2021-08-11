using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave4
    {
        public void InputMethod()
        {
            Console.Clear();
            int result = 0;
            bool canItConvert = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Tabel Counter ***");
                Console.Write("Hvilken tabel vil du have?: ");
                string str = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = int.TryParse(str, out result);
            }
            while (!canItConvert);

            //Vi sender vores svar videre for at kunne blive løst.
            CounterMethod(result);
        }
        void CounterMethod(int tal)
        {
            int tabel = 0, resultat;
            do
            {
                tabel++;
                resultat = tal * tabel;
                Console.WriteLine("{0} x {1} = {2}", tal, tabel, resultat);
            }
            while (tabel < 10);
            Console.ReadKey();
        }
    }
}
