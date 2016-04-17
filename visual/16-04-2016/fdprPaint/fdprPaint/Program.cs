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
            int max_y = Console.WindowHeight - 2;
            char[,] mappa = new char[max_x + 1, max_y + 1];

            char matita = '.';
            ConsoleKey input = ConsoleKey.A;
            printmenu(new string[] { "^X: Esci ^C Cambia carattere ^L Carica disegno ^S Salva disegno     ", "x: " + Console.CursorLeft + ", y: " + Console.CursorTop});

            while (input != ConsoleKey.X)
            {
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.LeftArrow:
                        x--;

                        printTo(ref x, ref y, max_x, max_y, matita, input, ref mappa);
                        break;
                    case ConsoleKey.RightArrow:
                        x++;

                        printTo(ref x, ref y, max_x, max_y, matita, input, ref mappa);
                        break;
                    case ConsoleKey.DownArrow:
                        y++;

                        printTo(ref x, ref y, max_x, max_y, matita, input, ref mappa);
                        break;
                    case ConsoleKey.UpArrow:
                        y--;

                        printTo(ref x, ref y, max_x, max_y, matita, input, ref mappa);
                        break;
                    case ConsoleKey.Insert:
                        if (matita == '.') matita = ' ';  else matita = '.';
                        break;
                }
            }
            Console.Clear();

            // x is width (oriz), y is height (vert), index 0 is x, index 1 is y
            int[] length = { mappa.GetLength(0), mappa.GetLength(1) };

            System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Daniil\diesgno.txt");

            for (int yy = 0; yy < length[1]; yy++)
            {
                for (int xx = 0; xx < length[0]; xx++)
                {
                    if (mappa[xx, yy] == '\0')
                    {
                        mappa[xx, yy] = ' ';
                    }
                    file.Write(mappa[xx, yy]);
                }
                file.WriteLine();
            }
            Console.ReadKey(true);
        }

        static void printmenu(string[] elements)
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            for (int x = 0; x < Console.WindowWidth; x++)
            {
                Console.Write(" ");
            }

            int space = Console.WindowWidth;
            for (int x = 0; x < elements.Length; x++)
            {
                Console.SetCursorPosition(Console.WindowWidth - space, Console.WindowHeight - 1);
                if (elements[x].Length > space / (elements.Length - x))
                {
                    space -= elements[x].Length + 1;
                }
                else space -= space / (elements.Length - x);
                Console.Write(elements[x]);
            }
            Console.ResetColor();
            Console.SetCursorPosition(0, 0);
        }
        static void checkmaxmin(ref int c, int max)
        {
            if(c < 0) {
                c = 0;
            } else if (c > max)
            {
                c--;
            }
        }
        static void printTo(ref int x, ref int y, int max_x, int max_y, char print, ConsoleKey last, ref char[,] mappa)
        {

            checkmaxmin(ref x, max_x);
            checkmaxmin(ref y, max_y);
            mappa[Console.CursorLeft, Console.CursorTop] = print;
            mappa[x, y] = print;

            Console.Write(print);
            Console.SetCursorPosition(x, y);
            Console.Write(print);
            Console.SetCursorPosition(x, y);
        }
    }
}
