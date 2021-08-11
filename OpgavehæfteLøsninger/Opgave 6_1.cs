using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave6_1
    {       
        public void InputMethod()
        {
            Console.Clear();
            double result = 0;
            bool canItConvert = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Circle calculator ***");
                Console.WriteLine("Here we will calculate the perimeter of a circle for you.");
                Console.Write("Insert radius: ");
                string str = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = double.TryParse(str, out result);
            }
            while (!canItConvert);

            //Vi sender vores svar videre for at kunne blive løst.
            double omkreds = CalculatorMethod(result);

            OutputMethod(omkreds, result);
        }
        double CalculatorMethod(double r)
        {
            //Her er formlen for omkreds af en cirkel med brug af radius. Math.PI giver hele PI.
            double O = 2 * r * Math.PI;

            //Her runder vi til 2 decimaler.
            double Omkreds2dec = Math.Round(O, 2);

            return Omkreds2dec;
        }
        void OutputMethod(double omkreds, double radius)
        {
            //Bruger $ så vi kan skrive vores double's i {}.
            Console.WriteLine($"A circle with {radius} in radius, will have {omkreds} in perimeter.");

            //Tester med at skrive true, da det så ikke vil vise hvad vi trykker til sidst.
            Console.ReadKey(true);
        }
    }
}
