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

            string Flipped = Flipper(str);

            OutputMethod(Flipped);
        }
        string Flipper(string name)
        {
            var words = name.Split(' ');
            var flipped = "";

            //Here it takes the last word and takes it out to the new var
            for (int i = 0; i < words.Length; i++)
            {
                flipped += (words[words.Length - i - 1] + " ");
            }
            return flipped;
        }
        void OutputMethod(string flipped)
        {
            Console.WriteLine(flipped);
            Console.ReadKey(true);
        }
    }
}
