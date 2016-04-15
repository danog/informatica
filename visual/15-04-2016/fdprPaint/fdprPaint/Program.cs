using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int max_y = Console.WindowHeight;
            int max_x = Console.WindowWidth -x;

            char matita = '.';
            ConsoleKey input = ConsoleKey.A;

            while (input != ConsoleKey.X)
            {
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.LeftArrow:
                        x--;
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        break;
                    case ConsoleKey.Insert:
                        if (matita == '.') matita = ' ';  else matita = '.';
                        break;
                }
                if (input != ConsoleKey.X)
                {
                    checkmaxmin(ref x, ref max_x);
                    checkmaxmin(ref y, ref max_y);
                    printTo(x, y, matita, input);
                }
            }
            Console.ReadKey(true);
        }

        static void checkmaxmin(ref int c, ref int max)
        {
            if(c < 0) {
                c = 0;
            }
            if (c > max)
            {
                c--;
            }
        }
        static void printTo(int x, int y, char print, ConsoleKey last)
        {

            Console.Write(print);
            Console.SetCursorPosition(x, y);
            Console.Write(print);
            Console.SetCursorPosition(x, y);
        }
    }
}
