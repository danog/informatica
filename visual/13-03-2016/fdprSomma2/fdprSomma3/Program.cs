using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprSomma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti numeri vuoi inserire? ");
            Console.WriteLine("Il risultato è {0}.", Addizione(Convert.ToDouble(Console.ReadLine()) + 1));
            Console.ReadKey();
        }
        static double LeggiNum(double volta)
        {
            Console.Write("Inserisci il " + volta + "^ valore: ");
            return Convert.ToDouble(Console.ReadLine());
            
        }
        static double Addizione(double v)
        {
            double num = 0;
            for (int x = 1; x < v; x++)
            {
                num = num + LeggiNum(x);   
            }
            return num;
        }
    }
}
