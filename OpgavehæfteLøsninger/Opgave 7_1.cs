using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave7_1
    {
        public void InputMethod()
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            Console.Clear();
            Console.WriteLine("*** Space Checker Machine ***");
            Console.WriteLine(@"Welcome, here we will count every space in this sentence:
""Lorem ipsum dolor sit amet, consectetur adipiscing elit."" .");
            Console.Write("Wanna write your own to use? (J/N): ");
            string jn = Console.ReadLine().ToLower();

            if (jn ==  "j")
            {
                Console.Write("Write a sentence");
                str = Console.ReadLine();
            }

            int spaces = SpaceCounter(str);

            OutputMethod(spaces, str);
        }
        int SpaceCounter(string sentence)
        {
            int countSpaces = sentence.Count(Char.IsWhiteSpace);
            return countSpaces;
        }
        void OutputMethod(int spaces, string text)
        {
            Console.WriteLine($"There is {spaces} spaces in the sentence: {text}");
            Console.ReadKey(true);
        }
    }
}
