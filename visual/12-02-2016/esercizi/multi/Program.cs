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
            int count = 0;
            List<int> nums = new List<int>();
            //bool fine = false;
            // Match the regular expression pattern against a text string.
            //byte i = 1;
            //for (byte i = 1; fine;)
            //for (;  i <= 5; i++)
            bool result = false;
            int[] ins = new int[6];
            string[] names = new string[11] { "Bari", "Cagliari", "Firenze", "Genova", "Milano", "Napoli", "Palermo", "Roma", "Torino", "Venezia", "Nazionale" };
            for (byte t = 1; t <= 5; t++)
            {
                while ((ins[t] <= 0 || ins[t] > 90) || result == false )
                {
                    Console.Write("Inserire il " + t + "^ numero della ruota di " + names[citta] + ": ");
                    result = int.TryParse(Console.ReadLine(), out ins[t]);
                };
            }
            for (byte i = 1; i <= 5; i++)
            {
                cur = numeroCasuale.Next(0, 91);
                while (nums.Contains(cur))
                {
                    cur = numeroCasuale.Next(0, 91);
                }

                nums.Add(cur);
                Console.WriteLine(names[citta] + ": " + cur);
                if (ins[i] == cur)
                {
                    count++;
                }
                //i++;
                //fine = i <= 5;
            }
            switch (count)
            {

                case 2:
                    Console.WriteLine("Congratulazioni! Avete fatto ambo!");
                    break;
                case 3:
                    Console.WriteLine("Congratulazioni! Avete fatto una terzina!");
                    break;
                case 4:
                    Console.WriteLine("Congratulazioni! Avete fatto una quartina!");
                    break;
                case 5:
                    Console.WriteLine("Congratulazioni! Avete fatto una quintina!");
                    break;
                default:
                    Console.WriteLine("Mi dispiace, non avete indovinato.");
                    break;

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
