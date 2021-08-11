using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave1_4
    {
        public void InputMethod()
        {
            Console.Clear();
            int result = 0, result2 = 0, result3 = 0;
            bool canItConvert = false, canItConvert2 = false, canItConvert3 = false;
            do
            {
                Console.Clear();
                Console.WriteLine("*** Regnskab ***");
                Console.Write("Indtast tallet for omsætning: ");
                string str = Console.ReadLine();
                Console.Write("Indtast tallet for variable omkostninger: ");
                string str2 = Console.ReadLine();
                Console.Write("Indtast tallet for faste omkostninger: ");
                string str3 = Console.ReadLine();

                //Her kontrolleres om det er tal der bliver skrevet.
                canItConvert = int.TryParse(str, out result);
                canItConvert2 = int.TryParse(str2, out result2);
                canItConvert3 = int.TryParse(str3, out result3);
            }
            while (!canItConvert || !canItConvert2 || !canItConvert3);

            //Vi sender vores svar videre for at kunne blive løst.
            CalculationMethod(result, result2, result3);
        }
        void CalculationMethod(double Omsætning, double Variable_Omkost, double Faste_Omkost)
        {
            double Dækningsbidrag, Overskud;
            //Beregenelser med kun double's
            Dækningsbidrag = Omsætning - Variable_Omkost;
            Overskud = Dækningsbidrag - Faste_Omkost;

            Console.WriteLine("Din dækningsbidrag er {0} og dit overskud er {1}", Dækningsbidrag, Overskud);
            Opgave1_5(Omsætning, Dækningsbidrag, Overskud);
        }
        void Opgave1_5(double Omsætning, double Dækningsbidrag, double Overskud)
        {
            string valg;
            int fejl = 0;

            //En valgmulighed for at forsætte til 1.5, da denne er en udvidelse af 1.4.
            do
            {
                Console.WriteLine("Vil du videre til 1.5? (J/N): ");
                valg = Console.ReadLine().ToUpper();

                switch (valg)
                {
                    case "J":
                        fejl = 0;
                        break;
                    case "N":
                        return;
                    default:
                        fejl = 1;
                        break;
                }
            }
            while (fejl == 1);

            double Dækningsgrad, Overskudsgrad;

            Dækningsgrad = Dækningsbidrag / Omsætning * 100;
            Overskudsgrad = Overskud / Omsætning;

            Console.WriteLine("Din dækningsgrad er {0} og din overskudsgrad er {1}", Dækningsgrad, Overskudsgrad);
            Console.ReadKey();
        }
    }
}
