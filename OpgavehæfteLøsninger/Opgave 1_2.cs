using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave1_2
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

            //Vi sender vores svar videre for at kunne blive løst.
            double F = ConversionFMethod(result);
            double K = ConversionKMethod(result);
            double R = ConversionRMethod(result);

            OutputMethod(result, F, K, R);
        }
        double ConversionFMethod(double C)
        {           
            double  F;

            //Beregenelser med tal.
            F = (C * 9 / 5) + 32;
            double F2dec = Math.Round(F, 2);
            return F2dec;                    
        }
        double ConversionKMethod(double C)
        {
            double K;

            //Beregenelse med tal.
            K = C + 273.15;
            double K2dec = Math.Round(K, 2);
            return K2dec;
        }
        double ConversionRMethod(double C)
        {
            double R;

            //Beregenelse med tal.
            R = C * 0.8;
            double R2dec = Math.Round(R, 2);
            return R2dec;
        }
        void OutputMethod (double C, double F, double K, double R)
        {
            Console.WriteLine(C + " Celcius er {0} Fahrenheit, {1} Kelvin og {2} Réaumur.", F, K, R);
            Console.ReadKey();
        }

    }
}
