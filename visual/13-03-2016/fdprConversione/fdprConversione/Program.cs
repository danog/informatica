using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprConversione
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Il risultato è {0}", Convert.ToString(legginum(), 2));
            Console.ReadKey();
        }
        static int legginum()
        {
            int input = -1;
            while (input < 0 || input > 255)
            {
                try 
	            {
                    Console.Write("Dammi il valore da convertire in binario (0-255): ");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 0 || input > 255)
                    {
                        Console.WriteLine("Hai inserito un numero troppo grande (o minore di zero). Prego riprovare.");
                    }
              	}
            	catch (Exception msg)
            	{

                    if (msg.HResult == -2146233033)
                    {

                        Console.WriteLine("Non hai inserito un numero. Prego riprovare.");
                    }
                    else
                    {
                        Console.WriteLine("C'è stato un errore. Prego riprovare.");
                    }
                    input = -1;
            	}
            }
            return input;
        }
    }
}
