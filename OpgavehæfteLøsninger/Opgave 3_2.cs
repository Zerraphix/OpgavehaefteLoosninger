using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave3_2
    {
        public void InputMethod()
        {
            Console.Clear();
            int result = 0;
            bool canItConvert = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Celcius Converter ***");
                Console.Write("Input celcius: ");
                string str = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = int.TryParse(str, out result);
            }
            while (!canItConvert);
            Console.Write("Hvad vil du have lavet Celcius omtil? Fahrenheit, Kelvin eller Réaumur. Skriv F, K eller R: ");
            string valg = Console.ReadLine().ToUpper();

            //Vi sender vores svar videre for at kunne blive løst.
            ConversionMethod(result, valg);
        }
        void ConversionMethod(double C, string valg)
        {
            double result, result2dec;
            //Har en switch case hvor jeg har delt beregnelserne op for dem alle 3.
            switch (valg)
            {
                case "F":
                    result = (C * 9 / 5) + 32;
                    result2dec = Math.Round(result, 2);
                    break;
                case "K":
                    result = C + 273.15;
                    result2dec = Math.Round(result, 2);
                    break;
                case "R":
                    result = C * 0.8;
                    result2dec = Math.Round(result, 2);
                    break;
                default:
                    Console.WriteLine("Fejl");
                    break;
            }
            Console.ReadKey();
        }

    }
}
