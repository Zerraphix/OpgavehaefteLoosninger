using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave1_3
    {
        public void InputMethod()
        {
            Console.Clear();
            int result = 0;
            bool canItConvert = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Kroner Converter ***");
                Console.Write("Vores kurs på Euro er 751. Hvor mange danske kroner vil du have lavet om? ");
                string str = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = int.TryParse(str, out result);
            }
            while (!canItConvert);

            //Vi sender vores svar videre for at kunne blive løst.
            double Euro = ConversionMethod(result);

            OutputMethod(result, Euro);
        }
        double ConversionMethod(double kroner)
        {
            Console.Clear();
            double euro;
            euro = kroner * 7.51;

            double euro2dec = Math.Round(euro, 2);
            return euro2dec;            
        }
        void OutputMethod(int kroner, double euro)
        {
            Console.WriteLine("Med {0} kroner, får du {1} euro.", kroner, euro);
            Console.ReadKey();
        }
    }
}
