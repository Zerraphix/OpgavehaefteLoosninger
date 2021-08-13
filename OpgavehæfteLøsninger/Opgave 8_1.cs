using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave8_1
    {
        public void InputMethod()
        {
            Console.Clear();
            List<string> måneder = new List<string>() { "Januar", "Februar", "Marts", "April", "Maj", "Juni", "Juli", "August", "September", "Oktober", "November", "December" };
            Console.WriteLine("*** Fun With Months ***");
            Console.WriteLine("Her er alle månederne:");
            foreach (string m in måneder)
            {
                Console.Write(m + " ");
            }
            Console.WriteLine("\n");
            Console.ReadKey(true);

            Console.WriteLine("Her er alle månederne der har et a i dem:");
            foreach (string m in måneder)
            {
                if (m.Contains("a") || m.Contains("A"))
                {
                    Console.Write(m + " ");
                }
            }
            Console.WriteLine("\n");
            Console.ReadKey(true);

            Console.WriteLine("Her er alle månederne der er længere end 4");
            foreach (string m in måneder)
            {
                if (m.Length > 4)
                {
                    Console.Write(m + " ");
                }
            }
            Console.WriteLine("\n");
            Console.ReadKey(true);

            var NewCalender = "";
            måneder.Add("Bichat");
            foreach (string m in måneder)
            {
                NewCalender += m + " ";
            }
            Console.WriteLine("Her er alle månederne, med en trettende måned");
            Console.WriteLine(NewCalender);
            Console.ReadKey(true);

        }
    }
}
