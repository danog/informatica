using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprStringa
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineainp;
            string lineainp2 = "";

            char carattere;
            Console.WriteLine("Inserisci una stringa di caratteri.");
            lineainp = Console.ReadLine();
            for (int i = 0; i < lineainp.Length; i++)
            {
                carattere = lineainp[i];
                lineainp2 += carattere;
                //lineainp[i] = Convert.ToString(carattere); non si può fareeeeee!!!!!!!!!
                Console.WriteLine("Lineainp di i: {0}", carattere);
            }
            Console.WriteLine(lineainp2);
            Console.ReadKey();
        }
    }
}
