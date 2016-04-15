using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Autore:Melon Federico
//Programma:Rettangolo
//Data:25/11/2015
//Rel.:0.1.0
//Descrizione:calolo area e perimetro rettangolo

namespace fdprRettangolo
{
    class Rettangolo
    {
        static void Main(string[] args)
        {//Dichiarazione variabili: tipo <identificatore>

            double perimetro;
            double area;
            double[] valori = new double[2];
            string[] errori = new string[2];
            errori[0] = "l'altezza";
            errori[1] = "la base";
            const long stringerror = -2146233033;
            bool working = true;
            string error;
            int i;
            //string[] mat = new string[2];
            //mat[1] = "val";
            //mat[2] = "val2";
            //Console.WriteLine("1 è "+mat[1]);
            
            //Console.WriteLine("2 è "+mat[2]);
            for (i = 0; i <= 1; i++) { 
                do
                {
                    try
                    {
                        Console.Write("Inserisci " + errori[i] + ": ");
                        valori[i] = Convert.ToDouble(Console.ReadLine());
                        if (valori[i] == 0)
                        {
                            working = true;
                            Console.WriteLine("Hai inserito un numero errato.");
                        }
                        else
                        {
                            working = false;
                        }
                    }

                    catch (Exception msg)
                    {
                        if (msg.HResult == stringerror)
                        {

                            error = "Non hai inserito un numero. Prego riprovare.";
                        }
                        else
                        {
                            error = "C'è stato un errore. Prego riprovare.";
                        }
                        Console.WriteLine(error);
                        working = true;
                    }
                } while (working);
            }

            // calcolo del perimetro
            //int perimetro;

            perimetro = (valori[0] + valori[1]) * 2;//operatori artimetici *,/,+,-,%

            area = valori[0] * valori[1];

            

            Console.WriteLine("Area[{0}]-Perimetro[{1}]", area,perimetro);
           //// Console.WriteLine("Perimetro[{0}]", perimetro);


            Console.WriteLine("Premi un tasto per continuare");
            Console.ReadLine();



        }
    }
}
