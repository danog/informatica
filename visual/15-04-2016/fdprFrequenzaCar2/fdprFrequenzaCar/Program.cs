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
            
            int[] count = new int[3];
            string[] wut = { "lettere", "numeri", "simboli" };
            //leggifermati("Inserisci 10 numeri: ", 10, ref nums, ref count);
            leggifermati("Inserisci 10 caratteri: ", 10, ref count);

            for (int x = 0; x < 3; x++) {
                if(count[x] != 0) Console.WriteLine("Hai inserito " + count[x] + " " + wut[x]);
            }
            Console.WriteLine("Ciao!");
            Console.ReadKey();
        }

        
        static void leggifermati(string cosa, int dove, ref int[] count)
        {
            Char input;

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
                    input = Console.ReadKey().KeyChar;
                    if(char.IsLetter(input)) {
                        count[0]++;
                    } else if(char.IsDigit(input)){
                        count[1]++;
                    } else {
                        count[2]++;
                    }
                }
                Console.ResetColor();

            Console.WriteLine("");
        }
    }

}
