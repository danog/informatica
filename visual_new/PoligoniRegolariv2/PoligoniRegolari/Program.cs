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
            byte lati = 0;
            double area, apotema, perimetro, lato = -1;
            float numeroFisso = 0f;
            string tipoPoligono = "";

            Console.WriteLine("Poligoni regolari.\n");
            do
            {
                Console.Write("Inserire il numero di lati del poligono: ");
                try
                {
                    lati = Convert.ToByte(Console.ReadLine());
                }
                catch (FormatException e)
                {
                }
                catch (OverflowException e)
                {
                }
                switch (lati)
                {
                    case 3:
                        numeroFisso = 0.289f;
                        tipoPoligono = "triangolo";
                        break;
                    case 4:
                        numeroFisso = 0.5f;
                        tipoPoligono = "quadrato";
                        break;
                    case 5:
                        numeroFisso = 0.688f;
                        tipoPoligono = "pentagono";
                        break;
                    default:
                        Console.WriteLine("Il numero di lati inserito non è valido.\a");
                        break;
                }
            } while (lati < 3 || lati > 5);


            Console.WriteLine();
            do
            {
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
                    Console.WriteLine("La lunghezza inserita non è valida.\a");
                }
            } while (lato < 0);


            Console.WriteLine();

            apotema = lato * numeroFisso;
            perimetro = lato * lati;
            area = (perimetro * apotema) / 2;
            Console.WriteLine("Tipo poligono: {0}\nNumero lati: {1}\nLunghezza lato: {2}\nNumero fisso: {3}\nValore apotema: {4}\nValore perimetro: {5}\nValore area: {6}", tipoPoligono, lati, lato, numeroFisso, apotema, perimetro, area);
            Console.Read();
        }
    }
}
