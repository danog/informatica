using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaDINNumeri
{
    class Program
    {
        static void Main(string[] args)
        {
            double somma = 0;
            int count = 0;
            do
            {
                Console.Write("Inserire un numero (scrivere una lettera per uscire): ");
                try
                {
                    somma += Convert.ToDouble(Console.ReadLine());
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
            Console.WriteLine("La media dei numeri inseriti è {0}", somma/count);
            Console.Read();
        }
    }
}
