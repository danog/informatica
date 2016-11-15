using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoligoniRegolari
{
    class Program
    {
        static void Main(string[] args)
        {
            int lati = 0;
            double area, apotema, perimetro, lato = -1, numeroFisso = 0;
            string tipoPoligono = "";
            Console.WriteLine("Poligoni regolari.\n");
            Console.Write("Inserire il numero di lati del poligono: ");
            try
            {
                lati = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
            }
            switch (lati)
            {
                case 3:
                    numeroFisso = 0.289;
                    tipoPoligono = "triangolo";
                    break;
                case 4:
                    numeroFisso = 0.5;
                    tipoPoligono = "quadrato";
                    break;
                case 5:
                    numeroFisso = 0.688;
                    tipoPoligono = "pentagono";
                    break;
                default:
                    Exit("Il numero di lati inserito non è valido.");
                    break;
            }
            Console.WriteLine();
            Console.Write("Inserire la lunghezza del lato: ");
            try
            {
                lato = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
            }
            if (lato < 0)
            {
                Exit("La lunghezza inserita non è valida.");
            }
            Console.WriteLine();

            apotema = lato * numeroFisso;
            perimetro = lato * lati;
            area = perimetro * apotema / 2;
            Console.WriteLine("Tipo poligono: {0}\nNumero lati: {1}\nLunghezza lato: {2}\nNumero fisso: {3}\nValore apotema: {4}\nValore perimetro: {5}\nValore area: {6}", tipoPoligono, lati, lato, numeroFisso, apotema, perimetro, area);
            Console.Read();
        }
        public static void Exit(string error)
        {
            Console.WriteLine(error + "\a");
            Console.Read();
            System.Environment.Exit(1);
        }
    }
}
