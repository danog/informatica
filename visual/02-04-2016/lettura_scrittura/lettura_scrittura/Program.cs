using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lettura_scrittura
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Lettura(4, (Console.WindowWidth / 2) - 2, Console.WindowTop, ConsoleColor.Magenta, ConsoleColor.Green);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Scrittura(input, (Console.WindowWidth / 2) - (input.Length/2), Console.WindowTop, ConsoleColor.White, ConsoleColor.Black);
            Console.ReadKey();
        }
        static void Scrittura(string stringa, int x, int y, ConsoleColor coloreSfondo, ConsoleColor coloreTesto)
        {
            //ConsoleColor sfondo = Console.BackgroundColor;
            //ConsoleColor testo = Console.ForegroundColor;


            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = coloreSfondo;
            Console.ForegroundColor = coloreTesto;
            Console.Write(stringa);

            //Console.BackgroundColor = sfondo;
            //Console.ForegroundColor = testo;
            Console.ResetColor();
            Console.WriteLine("");
        }
        static string Lettura(int dimensione, int x, int y, ConsoleColor coloreSfondo, ConsoleColor coloreTesto)
        {
            string concat = "";
            char input;
            bool ok = false;

            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = coloreSfondo;
            Console.ForegroundColor = coloreTesto;

            for (int a = 0; a < dimensione; a++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(x, y);

            for (int a = 0; a < dimensione; a++)
            {
                ok = false;
                while (ok == false)
                {
                    input = Console.ReadKey(true).KeyChar;
                    if (Char.IsLetterOrDigit(input))
                    {
                        Console.Write(input);
                        concat += input;
                        ok = true;
                    }
                }
            }

            Console.ResetColor();
            return concat;
            
        }
    }
}
