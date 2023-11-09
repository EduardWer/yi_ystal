using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ia_ystal
{
    internal class Menus
    {
        public int min;
        public int max;
        private int CursorPos;
        private ConsoleKeyInfo key;

        public Menus(int Min, int Max)
        {
            min = Min;
            max = Max;
        }

        public int Menu()
        {
            CursorPos = min;
            while(true)
            {
                Console.SetCursorPosition(0, CursorPos);
                Console.Write("->");
                Console.SetCursorPosition(0,0);
                key = Console.ReadKey();
                Console.SetCursorPosition(0, CursorPos);
                Console.Write("  ");
                if (key.Key == ConsoleKey.UpArrow && CursorPos > min)
                {
                    CursorPos--;
                }
                if (key.Key == ConsoleKey.DownArrow && CursorPos < max)
                {
                    CursorPos++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    return CursorPos;
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    return 0;
                }
            }
        }
    }
}
