using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroCasuale = new Random();
            Random cittaCasuale = new Random();
            int citta = cittaCasuale.Next(0, 12);
            int cur;
            List<int> nums = new List<int>();
            //bool fine = false;
            // Match the regular expression pattern against a text string.
            //byte i = 1;
            //for (byte i = 1; fine;)
            //for (;  i <= 5; i++)

            string[] names = new string[11] { "Bari", "Cagliari", "Firenze", "Genova", "Milano", "Napoli", "Palermo", "Roma", "Torino", "Venezia", "Nazionale" };

            for (byte i = 1; i <= 5; i++)
            {
                cur = numeroCasuale.Next(0, 91);
                while (nums.Contains(cur))
                {
                    cur = numeroCasuale.Next(0, 91);
                }

                nums.Add(cur);
                Console.WriteLine(names[citta] + ": " + cur);
                //i++;
                //fine = i <= 5;
            }
            //Console.WriteLine(n);
            Console.Read();
            /* 
               Bari
               Cagliari
               Firenze 
               Genova
               Milano
               Napoli
               Palermo
               Roma
               Torino
               Venezia
               Nazionale
             */
        }
    }
}
