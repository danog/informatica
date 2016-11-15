using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassimoFraN
{    class Program
    {
        static void Main(string[] args)
        {
            double max = 0;
            double n = 0;
            int count = 0;
            do
            {
                Console.Write("Inserire un numero (scrivere una lettera per uscire): ");
                try
                {
                    n = Convert.ToDouble(Console.ReadLine());
                    if (n > max) {
                        max = n;
                    }
                }
                catch (FormatException e)
                {
                    if (count < 2)
                    {
                        Console.WriteLine("Dovete inserire almeno 2 numeri.");
                        continue;
                    }
                    break;
                }
                count++;
            } while (true);
            Console.WriteLine("Il massimo numero tra quelli che avete inserito è {0}", max);
            Console.Read();
        }
    }
}