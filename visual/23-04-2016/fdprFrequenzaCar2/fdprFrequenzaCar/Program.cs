using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprFrequenzaCar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] count = new int[37];
            string[] wut = { "lettere", "numeri", "simboli" };

            leggifermati("Inserisci 10 caratteri: ", 10, ref count);

            for (int x = 0; x < 3; x++) {
                if(count[x] != 0) Console.WriteLine("Hai inserito " + count[x] + " " + wut[x]);
            }
            Console.WriteLine("Ciao!");
            Console.ReadKey();
        }

        
        static void leggifermati(string cosa, int dove, ref int[] hertz)
        {

            int input;
            Console.Clear();
            Console.Write(cosa); // Scrivi messaggio
            Console.BackgroundColor = ConsoleColor.Gray; // Cambia colore di sfondo e colore principale
            Console.ForegroundColor = ConsoleColor.Black;
            for (int x = 1; x < dove; x++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(cosa.Length, Console.CursorTop);
            for (int x = 0; x < dove; x++)
            {
                    input = Console.ReadKey().KeyChar; // A = 65, Z = 90,a = 97, z = 122
                    if (input >= 97 && input <= 122) input -= 32;
                    if (input >= 65 && input <= 90) hertz[input - 55]++; else if (input >= 48 && input <= 57) hertz[input - 48]++; else hertz[36]++;

            }
                Console.ResetColor();

                for (int i = 0; i < hertz.Length - 1; i++)
                {
                    if (hertz[i] > 0 && i < 10)
                    {
                        Console.WriteLine("Carattere {0} frequenza = {1}", i, hertz[1]);
                    }
                }
                Console.WriteLine("");
        }
    }

}
