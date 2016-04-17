using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string path;
            char[,] mappa = new char[max_x + 1, max_y + 1];
            Console.TreatControlCAsInput = true;

            char matita = '\0';
            ConsoleKeyInfo input = new ConsoleKeyInfo('W', ConsoleKey.W, false, false, false);

            printmenu(new string[] { "^X: Exit", "^C Change char", "^L Load", "^O Save", "x: " + Console.CursorLeft + ", y: " + Console.CursorTop }, true);

            while (!(input.Key == ConsoleKey.X && input.Modifiers == ConsoleModifiers.Control))
            {
                input = Console.ReadKey(true);

                if (input.Modifiers == ConsoleModifiers.Control)
                {
                    switch (input.Key)
                    {
                        case ConsoleKey.C:
                            matita = Convert.ToChar(readmenu("Input your char: ", 1));
                            break;
                        case ConsoleKey.L:
                            break;
                        case ConsoleKey.O:
                            path = readmenu("Input the destination file path: ", 1000000);/*
                            do {
                                path = readmenu("Wrong file path! Input the destination file path: ", 1000000);
                            } while (!*/
                            Console.WriteLine(printtofile(ref mappa, path));
                            break;
                    }

                } else {
                    switch (input.Key)
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
                    }

                    printTo(ref x, ref y, max_x, max_y, matita, input.Key, ref mappa);
                }
                printmenu(new string[] { "^X: Exit", "^C Change char", "^L Load", "^O Save", "x: " + Console.CursorLeft + ", y: " + Console.CursorTop }, true);

            }
        }

        static bool printtofile(ref char[,] mappa, string dest)
        {

            // x is width (oriz), y is height (vert), index 0 is x, index 1 is y
            string result; 
            try
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@dest);
                
                if() {
                    do {
                        readmenu("File exists. Overwrite (y/n)?", 1);
                    } while(result != "y" || result != "n")
                }
                
                for (int yy = 0; yy < mappa.GetLength(1); yy++)
                {
                    for (int xx = 0; xx < mappa.GetLength(0); xx++)
                    {
                        if (mappa[xx, yy] == '\0')
                        {
                            mappa[xx, yy] = ' ';
                        }
                        file.Write(mappa[xx, yy]);
                    }
                    file.WriteLine();
                }
                file.Close();
            } catch(Exception) {
                return false;
            }
            

            return true;
        }

        static string readmenu(string wut, int dove)
        {
            string input = "";
            char inputchar;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            printmenu(new string[] { wut }, false);

            for (int x = 1; x <= dove; x++)
            {
                inputchar = Convert.ToChar(Console.Read());
                if (inputchar == '\r')
                {
                    x = dove + 1;
                } else input += inputchar.ToString();
            }
            Console.SetCursorPosition(0, 0);
            Console.SetCursorPosition(left, top);
            Console.ResetColor();
            return input;
        }
        static void printmenu(string[] elements, bool reset)
        {
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
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
            if (reset == true)
            {
                Console.ResetColor();
                Console.SetCursorPosition(0, 0);
                Console.SetCursorPosition(left, top);
            }
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
