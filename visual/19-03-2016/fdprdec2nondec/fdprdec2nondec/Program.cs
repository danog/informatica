using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprdec2nondec
{
    class Program
    {
        static void Main(string[] args)
        {
            int valore;
            int basedaconv;
            legginum(255, "Dammi il valore da convertire in binario", ref int valore);

        }
        static void legginum(int limite, string cosa, ref int input)
        {
            input = -1;
            while (input < 0 || input > limite)
            {
                try
                {
                    Console.Write(cosa + " (0-"+limite+"): ");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input < 0 || input > limite)
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
        }
    }
}
