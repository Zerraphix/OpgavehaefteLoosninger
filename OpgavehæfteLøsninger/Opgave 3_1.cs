using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave3_1
    {
        public void InputMethod()
        {
            Console.Clear();
            int nummer;
            Console.Write("Hvilken nummer dag hvil du? ");
            nummer = Convert.ToInt32(Console.ReadLine());

            OutputMethod(nummer);           
        }
        void OutputMethod(int nummer)
        {
            string dag;
            //Her ændres vores string ud fra hvad vores int er.
            switch (nummer)
            {
                case 1:
                    dag = "Mandag";
                    break;
                case 2:
                    dag = "Tirsdag";
                    break;
                case 3:
                    dag = "Onsdag";
                    break;
                case 4:
                    dag = "Torsdag";
                    break;
                case 5:
                    dag = "Fredag";
                    break;
                case 6:
                    dag = "Lørdag";
                    break;
                case 7:
                    dag = "Søndag";
                    break;
                default:
                    dag = "mystisk dag";
                    break;
            }
            Console.WriteLine("I dag er det {0}", dag);
            Console.ReadKey();
        }
    }
}
