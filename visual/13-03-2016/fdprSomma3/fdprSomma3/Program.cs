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
        static int errore = 0; // Diventa zero da sola

        static void Main(string[] args)
        {

            Console.Write("Quanti numeri vuoi inserire? ");
            double v = Convert.ToDouble(Console.ReadLine());
            Addizione(v);
            if (errore != -1)
            {

                Console.WriteLine("Il risultato è " + num);
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("ERROR!");
            }
            Console.ReadKey();

            //double num = 4;
            //LeggiNum();
            //Console.WriteLine(num); // variabile locale = 4
            //Console.ReadLine();
        }
        static void LeggiNum(double volta)
        {
            Console.Write("Inserisci il " + volta + "^ valore: ");
            insnum = Convert.ToDouble(Console.ReadLine());
            //if (insnum == 0)
            //{
            //    errore = -1;
            //    return;
            //}
            //else
            //{
            //    errore = 0;

            //} // Utilizzo del return
            if (num == 0)
            {
                errore = -1;
            }
            else
            {
                errore = 0;
            }
        }
        static void Addizione(double volte)
        {
            for (int x = 1; x < volte + 1; x++)
            {
                LeggiNum(x);
                if (errore == -1)
                {
                    return;
                }
                else
                {
                    num = num + insnum;
                }
                
            }
        }
    }
}
