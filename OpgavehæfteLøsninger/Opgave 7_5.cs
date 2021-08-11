using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave7_5
    {
        public void InputMethod()
        {
            string str;
            Console.Clear();
            Console.WriteLine("*** Flip Name Machine ***");
            Console.WriteLine("Welcome, here we will make your last name by the first name and everything else comes after.");
            Console.Write("Write a full name: ");
            str = Console.ReadLine();

            Flipper(str);

            //OutputMethod(name);
        }
        void Flipper(string name)
        {
            var words = name.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                System.Console.Write(words[words.Length - i - 1]);
            }
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
