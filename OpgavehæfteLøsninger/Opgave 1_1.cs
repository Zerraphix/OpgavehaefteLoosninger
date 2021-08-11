using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave1_1
    {
        public void InputMethod()
        {
            Console.Clear();
            int result = 0;
            bool canItConvert = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Fahrenheit Converter ***");
                Console.Write("Input fahrenheit: ");
                string str = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = int.TryParse(str, out result);
            }
            while (!canItConvert);

            //Vi sender vores svar videre for at kunne blive løst.
            double celsius = ConversionMethod(result);

            OutputMethod(celsius);
        }

        double ConversionMethod(double fahrenheit)
        {
            //Her laver vi Fahrenheit om til Celcius.
            double celsius = (fahrenheit - 32) * 5 / 9;

            //Her runder vi til 2 decimaler.
            double celsius2dec = Math.Round(celsius, 2);

            return celsius2dec;
        }
        void OutputMethod(double celsius)
        {
            Console.WriteLine("F to C " + celsius);
            Console.ReadKey();
        }
    }
}
