using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave7_2
    {
        public void InputMethod()
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            Console.Clear();
            Console.WriteLine("*** Space Replacer Machine ***");
            Console.WriteLine(@"Welcome, here we will replace every space by making a new line in this sentence:
""Lorem ipsum dolor sit amet, consectetur adipiscing elit."" .");
            Console.Write("Wanna write your own to use? (J/N): ");
            string jn = Console.ReadLine().ToLower();

            if (jn == "j")
            {
                Console.Write("Write a sentence");
                str = Console.ReadLine();
            }

            string text = SpaceReplacer(str);

            OutputMethod(text);
        }
        string SpaceReplacer(string text)
        {
            text.Replace(" ", "\n");
            return text;
        }
        void OutputMethod(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
    }
}
