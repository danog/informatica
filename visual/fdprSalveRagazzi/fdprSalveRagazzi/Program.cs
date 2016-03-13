using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprSalveRagazzi
{
    class Program
    {
        static void ArrivederciRagazzi()
        {
            Console.WriteLine("Arrivederci Daniil!");
        }
        static void Main(string[] args)
        {
            SalveRagazzi(); // Invocazione o chiamata del metodo
            Console.ReadLine();
        }
        static void SalveRagazzi() /* Prototipo composto: da modificatore di accesso composto
                                    * Valore di ritorno o void
                                    * Identificatore del metodo
                                    * Lista dei parametri
                                    */
        {
            Console.WriteLine("Bentornato Gentili Daniil!"); // Corpo del metodo
            Console.ReadLine();
            ArrivederciRagazzi();

        }
    }
    
}
