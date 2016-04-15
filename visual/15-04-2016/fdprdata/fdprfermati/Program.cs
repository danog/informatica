using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprfermati
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int[] data = string2data(leggifermati("Dammi una data (formato ggmmaaaa): ", 8));

            while (end == false) {
                Console.WriteLine("La data corrente è: " + data[0] + "/" + data[1] + " del " + data[2]);
                Console.WriteLine("Premere i pulsanti su e giù per aggiungere o sottrarre un giorno alla data inserita, premere e per uscire.");
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                           change(1, ref data);
                           break;
                    case ConsoleKey.DownArrow:
                           change(-1, ref data);
                           break;
                    case ConsoleKey.E:
                           end = true;
                           break;
                };
            }
        }
        static void change(int cmd, ref int[] data)
        {
            // indice 0 = giorno
            // indice 1 = mese
            // indice 2 = anno

            data[0] = data[0] + cmd;
            if (data[0] > DateTime.DaysInMonth(data[2], data[1]))
            {
                data[0] = data[0] - DateTime.DaysInMonth(data[2], data[1]);
                data[1]++;
            }
            
            if (data[0] < 1)
            {
                data[1]--;
                if (data[1] < 1)
                {
                    data[2]--;
                    data[1] = 12;
                }
                data[0] = DateTime.DaysInMonth(data[2], data[1]);
            }

            if (data[1] > 12)
            {
                data[1] = 1;
                data[2]++;
            }
        }
        static bool controllo(string data)
        {
            int year = Convert.ToInt32(data.Substring(data.Length - 4));
            int month = Convert.ToInt32(data.Substring(2, 2));
            int day = Convert.ToInt32(data.Substring(0, 2));

            System.Threading.Thread.Sleep(1000);

            if(year < DateTime.MinValue.Year || year > DateTime.MaxValue.Year) return false;
            if(month < 1 || month > 12) return false;
            return day > 0 && day <= DateTime.DaysInMonth(year, month);
            
        }
        static int[] string2data(string data) {
            int[] date = new int[3];
            date[0] = Convert.ToInt32(data.Substring(0, 2)); // giorno
            date[1] = Convert.ToInt32(data.Substring(2, 2)); // mese
            date[2] = Convert.ToInt32(data.Substring(data.Length - 4)); // anno
            return date;
        }
        static string leggifermati(string cosa, int dove)
        {
            int input;
            string concat = "";
            bool ok = false;


            while (ok == false)
            {
                concat = "";
                Console.Clear();
                Console.Write(cosa); // Scrivi messaggio
                Console.BackgroundColor = ConsoleColor.Gray; // Cambia colore di sfondo e colore principale
                Console.ForegroundColor = ConsoleColor.Black;
                for (int x = 0; x < dove; x++)
                {
                    Console.Write(" ");
                }
                Console.SetCursorPosition(cosa.Length, Console.CursorTop);
                for (int x = 1; x <= dove; x++)
                {
                    input = -1;
                    while (input < 0 || input > 9)
                    {
                        try
                        {
                            Console.SetCursorPosition(cosa.Length + x - 1, Console.CursorTop);
                            Console.Write(" ");
                            Console.SetCursorPosition(cosa.Length + x - 1, Console.CursorTop);

                            input = int.Parse(Console.ReadKey(true).KeyChar.ToString());
                            Console.Write(input);
                        }
                        catch (Exception)
                        {
                            input = -1;
                        }
                    }
                    concat += input;
                }
                ok = controllo(concat);

                Console.ResetColor();
            }
            Console.WriteLine("");
            return concat;
        }
    }
}
