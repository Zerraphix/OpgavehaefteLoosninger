using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave5_2
    {
        public void CounterMethod()
        {
            Console.Clear();
            Console.WriteLine("*** Celcius and Fahrenheit counter ***");
            Console.WriteLine("Welcome to my Celius and Fahrenheit counter that counts in 10's. ");
            Console.WriteLine("Press any button to begin.");
            Console.ReadKey();

            for (double C = 10; C <= 100; C = C + 10)
            {
                double F = 0;
                F = (C * 9 / 5) + 32;
                double F2dec = Math.Round(F, 2);
                Console.WriteLine(C + "C°, " + F2dec + "F°");
            }
            Console.ReadKey();
        }
    }
}
