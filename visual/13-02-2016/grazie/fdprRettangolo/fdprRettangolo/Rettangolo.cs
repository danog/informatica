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
        {
            int altezza = 0;
            int Base = 0;
            int valore = 0;
            bool ripeti;
            const long errore = -2146233033;//inserimento lettere
            const long errore1 = -2146233066;//inserimento numero out range

            //inserimento e controllo
            
            for (byte i = 0; i <= 1; i++)//per inserire la base e l'altezza senza rindondanze
            {
                if(i==0)
                    Console.Write("Inserisci la base: ");
                else
                    Console.Write("Inserisci l'altezza: ");

                do//nel caso di errore di inserimento
                {
                    ripeti = false;
                    try
                    {
                        valore = Convert.ToInt32(Console.ReadLine());
                        if (valore <= 0)
                        {
                            Console.Write("Valore errato, reinserire il numero: ");
                            ripeti = true;                            
                        }
                    }
                    catch (Exception msg)//gestione errore 
                    {
                        if (msg.HResult == errore || msg.HResult == errore1)
                        {
                            Console.Write("Formato errato, reinserire il numero: ");
                            ripeti = true;
                        }
                    }
                    
                } while (ripeti);
                if (i == 0)
                    Base = valore;
                else
                    altezza = valore;
            }
            Console.Clear();//cancella la merda di inserimento
            Console.WriteLine("\nLa base è {0}\nL'altezza è {1}", Base, altezza);
            Console.WriteLine("Il perimetro è {0}\nL'area è {1}", (Base + altezza) * 2, Base * altezza);
            Console.ReadLine();
        }
    }
}
