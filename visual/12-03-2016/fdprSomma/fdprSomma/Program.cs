using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprSomma
{
    class Program
    {
        static double insnum;
        static double num;
        static double t = 32;
        static void Main(string[] args)
        {
            Console.Write("Quanti numeri vuoi inserire? ");
            double v = Convert.ToDouble(Console.ReadLine());
            Addizione(v);
            Console.WriteLine("Il risultato è "+num);
            Console.ReadKey();

            //double num = 4;
            //LeggiNum();
            //Console.WriteLine(num); // variabile locale = 4
            //Console.ReadLine();
        }
        static void LeggiNum(double volta)
        {
            Console.Write("Inserisci il "+volta+"^ valore: ");
            insnum = Convert.ToDouble(Console.ReadLine());
        }
        static void Addizione(double volte) 
        {
            for (int x = 1; x < volte+1; x++)
            {
                LeggiNum(x);
                num = num + insnum;
            }
            Console.WriteLine(t);
        }
    }
}
