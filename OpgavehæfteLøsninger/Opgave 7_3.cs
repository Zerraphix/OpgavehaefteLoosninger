using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave7_3
    {
        public void InputMethod()
        {
            string str;
            Console.Clear();
            Console.WriteLine("*** capitalize name machine ***");
            Console.WriteLine("Welcome, here we will capitalize first letter of every word in the full name you write.");
            Console.Write("Write a full name: ");
            str = Console.ReadLine().ToLower();

            string name = ToUpperEveryWord(str);

            OutputMethod(name);
        }
        string ToUpperEveryWord(string name)
        {
            //Here we split up the name into parts
            var words = name.Split(' ');
            var upper = "";

            //Here for each part we take the first word and then capitalize it with char.ToUpper(word[0])
            //The other command takes the rest of the names, so we can have the full name.
            foreach (var word in words)
            {
                upper += char.ToUpper(word[0]) + word.Substring(1) + ' ';
            }          
            return upper;
        }
        void OutputMethod(string fullname)
        {
            Console.WriteLine("Så har vi gjort hvert først bogstav stort " + fullname);
            Console.ReadKey(true);
        }
    }
}
