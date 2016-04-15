using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimale,conv;
            Console.WriteLine("Inserisci un valore decimale nel range 1 a 255 ");
            decimale = Console.ReadLine();
            Console.WriteLine("Inserisci un valore per convertire nel range 2 a 16 ");
            conv = Console.ReadLine();


            if (ControloDeiNumeri(decimale, conv))
            {
                Console.WriteLine("Il valore convertito è {0} con base {1} e risulta {2}", Convertore(Convert.ToInt32(decimale), Convert.ToInt32(conv)), Convert.ToInt32(decimale), Convert.ToInt32(conv));
            }
            else
            {
                Console.WriteLine("valore input errato");
            }
            Console.ReadLine();
        }
        static string Convertore(int decimale, int conv)
        {
            string risultato="", risultato1="";
            int resto;
            do
            {
               resto = decimale % conv;
                decimale =decimale/ conv;

               // if (conv > 9)
                //{



                    switch (resto)
                    {
                        case 0: risultato1 = "0"; break;
                        case 1: risultato1 = "1"; break;
                        case 2: risultato1 = "2"; break;
                        case 3: risultato1 = "3"; break;
                        case 4: risultato1 = "4"; break;
                        case 5: risultato1 = "5"; break;
                        case 6: risultato1 = "6"; break;
                        case 7: risultato1 = "7"; break;
                        case 8: risultato1 = "8"; break;
                        case 9: risultato1 = "9"; break;
                        case 10: risultato1 = "A"; break;
                        case 11: risultato1 = "B"; break;
                        case 12: risultato1 = "C"; break;
                        case 13: risultato1 = "D"; break;
                        case 14: risultato1 = "E"; break;
                        case 15: risultato1 = "F"; break;



                    }
                    risultato = risultato1 + risultato;
               // }
               /* else
                {
                    risultato = resto + risultato;
                }*/



            }while (decimale !=0);



            return risultato;
        }
        static int ControloDeiNumeri (string decimale,string conv)
        {
            int valore,b;
            try
            {
                b = Convert.ToInt32(conv);
                valore = Convert .ToInt32 (decimale);
                if ((valore < 0 || valore > 256) & (b<1||b>17 ))
                {
                    return false;
                }
                else
                {
                    return true;
                }
              
               


            }
            catch(Exception )
            {
                return false;

            }
           


           // return false;
        }
    }
}
