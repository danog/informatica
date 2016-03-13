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
            /*
             * Console.Write("Quanti numeri vuoi inserire? ");
             * Console.WriteLine("Il risultato è {0}.", Addizione(Convert.ToDouble(Console.ReadLine()) + 1));
             */
            Risultato(Addizione(LeggiNum(), LeggiNum()));
            Console.ReadKey();
        }
        static double LeggiNum()
        {
            Console.Write("Inserisci un valore: ");
            return Convert.ToDouble(Console.ReadLine());

        }
        static double Addizione(double add1, double add2)
        {
            return add1 + add2;
        }
        static void Risultato(double cosa) {
            Console.WriteLine("Il risulato è {0}", cosa);
        }
    }
}
