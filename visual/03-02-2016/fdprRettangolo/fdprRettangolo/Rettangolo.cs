using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Autore: Bacco Luca
// Programma: Rettangolo
// Data: 25/11/15
// Rel: 0.1.0
// Descrizione: calcolo area e perimentro rettangolo
namespace fdprRettangolo
{
    class Rettangolo
    {
        static void Main(string[] args)
        {//Dichiarazione variabili: tipo <identificatore>
            /*int baseRettangolo, altezzaRettangolo; //input base e altezza*/
              double baseRettangolo; //valore base
              double altezzaRettangolo; //valore altezza
              double perimetro;// contiene perimetro del rettangolo
              double area;// contiene l'area del rettangolo
           
              baseRettangolo = 5.2;
              altezzaRettangolo = 4;

              //calcolo del perimetro
              perimetro = (baseRettangolo + altezzaRettangolo) * 2;//operatori aritmetici in C# *,/,+,-,%(Resto in excel)
              // int  perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            
              //calcolo area
              area = baseRettangolo * altezzaRettangolo;
              // int area = baseRettangolo * altezzaRettangolo;
              
              //visualizzazione dei risultati
              //area
             /* Console.Write("Area");
              Console.Write("[");
              Console.Write(area);
              Console.WriteLine("]");
              Console.WriteLine();
              //Console.WriteLine();
              Console.Write("Perimetro");
              Console.Write("[");
              Console.Write(perimetro);
              Console.WriteLine("]");
              Console.WriteLine();
              Console.WriteLine("Premi un tasto per continuare");
              Console.ReadLine();*/
              Console.WriteLine("Il perimetro è {0} \nL'area è {1}", perimetro, area);
              Console.WriteLine("Premi un tasto per continuare");
              Console.ReadLine();



        }
    }
}
