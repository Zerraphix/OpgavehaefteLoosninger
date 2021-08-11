using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgavehæfteLøsninger
{
    class Opgave4_1
    {
        public void SquareMethod()
        {
            int vandret, lodret, tæller = 1, side, op, hopper = 6, fylder;
            Console.Clear();
            Console.WriteLine("*** Box Maker 2000 ****");
            Console.Write("Indtast vandret start: ");
            fylder = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast lodret start : ");
            lodret = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(5, 5);
            Console.Write("┌");
            vandret = fylder * 2;
            side = vandret + 5;
            op = lodret + 5;

            do
            {
                Console.Write("─");
                tæller++;
            }
            while (tæller < vandret);
            tæller = 1;
            Console.Write("┐");
            do
            {
                Console.SetCursorPosition(side, hopper);
                Console.Write("│");
                tæller++;
                hopper++;
            }
            while (tæller < lodret);
            Console.SetCursorPosition(side, op);
            Console.Write("┘");
            hopper = 6;
            tæller = 1;
            do
            {
                Console.SetCursorPosition(5, hopper);
                Console.Write("│");
                tæller++;
                hopper++;
            }
            while (tæller < lodret);
            Console.SetCursorPosition(5, op);
            Console.Write("└");
            tæller = 1;
            do
            {
                Console.Write("─");
                tæller++;
            }
            while (tæller < vandret);
            Console.ReadKey();
        }
    }
}
