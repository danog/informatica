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
            
            int[] count = new int[10];
            //int[] nums = new int[10]; // è necessario?

            //leggifermati("Inserisci 10 numeri: ", 10, ref nums, ref count);
            leggifermati("Inserisci 10 numeri: ", 10, ref count);

            for (int x = 0; x < 10; x++) {
                if(count[x] != 0) Console.WriteLine("Hai inserito " + count[x] + " volte " + x);
            }
            Console.WriteLine("Ciao!");
            Console.ReadKey();
        }

        
        //static int[] leggifermati(string cosa, int dove, ref int[] inputs, ref int[] count)
        static void leggifermati(string cosa, int dove, ref int[] count)
        {
            int input;
            bool ok = false;


            while (ok == false)
            {
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
                    input = -1;
                    while (input < 0 || input > 9)
                    {
                        try
                        {
                            Console.SetCursorPosition(cosa.Length + x - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(cosa.Length + x - 1, Console.CursorTop);

                            input = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());
                            Console.Write(input);
                        }
                        catch (Exception)
                        {
                            input = -1;
                        }
                    }
                    //inputs[x] += input;
                    count[input]++;
                }
                ok = true;
                Console.ResetColor();
            }
            Console.WriteLine("");
        }
    }

}
