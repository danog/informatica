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
            // barra griga sotto con menu di salvataggio con coordinate, valore personalizzato e colore personalizzato usa serialize per scirvere proprio i caratteri 
            int x = 0;
            int y = 0;
            int max_x = Console.WindowWidth - 1;
            int max_y = Console.WindowHeight - 1;
            char[,] mappa = new char[max_x, max_y];

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
                    printTo(x, y, matita, input, ref mappa);
                }
            }
            Console.Clear();

            // x is width (oriz), y is height (vert), index 0 is x, index 1 is y

            int[] length = { mappa.GetLength(0), mappa.GetLength(1) };

            for (int yy = 0; yy < length[1]; yy++)
            {
                for (int xx = 0; xx < length[0]; xx++)
                {
                    Console.Write(mappa[xx, yy]);
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
        static void printTo(int x, int y, char print, ConsoleKey last, ref char[,] mappa)
        {
            mappa[Console.CursorLeft, Console.CursorTop] = print;
            mappa[x, y] = print;

            Console.Write(print);
            Console.SetCursorPosition(x, y);
            Console.Write(print);
            Console.SetCursorPosition(x, y);
        }
    }
}
