using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //collezioni di dati, all'interno di un array vengono memorizzati dati omogenei dello stesso tipo
            //inoltre è una struttura in grado di memorizzare più dati dello stesso tipo
            //collezioni di dati: tipo dei dati che la compongono (strutture,intero,string), dall'organizzazione interna,dalla modalità d'accesso
            //e dalla possibilità d'aggiungere o togliere i dati
            //Array è una collezione di dati omogenei dello stesso tipo,è statica ed è allocata in memoria,non si possono aggiungere e togliere dati
            //si accede agli elementi tramite un indice

            //int[] numeri;//definito che numeri è una variabile di tipo vettore, statica
            /*
            int[] numeri=new int [10] ;

            int[] numeri2 = new int[10];
            Random numero = new Random();

            for(int indice=0;indice<numeri.Length;indice++)
            {
                
                numeri [indice]= numero.Next(99) + 1;
                numeri2[indice] = numero.Next(100,200);
            }

            for (int indice = 0; indice < numeri.Length; indice++)
            {
                Console.WriteLine("[{0}]Vet 1={1};Vet 2={2} ",indice+1, numeri[indice], numeri2[indice]);
            }

            numeri = numeri2;//si è assegnato alla stessa variabile l'indirizzo a cui punta numeri2

            Console.WriteLine();
            for (int indice = 0; indice < numeri.Length; indice++)
            {
                Console.WriteLine("[{0}]Vet 1={1};Vet 2={2} ", indice + 1, numeri[indice], numeri2[indice]);
            }
            */
            /*Console.WriteLine();
            Console.WriteLine(numeri[0]);
            Console.WriteLine(numeri[9]);

            numeri[0] = 99;
            numeri[9] = 1;
            Console.WriteLine(numeri[0]);
            Console.WriteLine(numeri[9]);*/

            //leggere la frequenza delle cifre contenute in un numero intero
            

            //Console.WriteLine("Quanti elementi vuoi inserire nel vettore?");
            //int dim = Convert.ToInt32(Console.ReadLine());
            //int[] numeri = new int[dim];
            //int[] numeri2 = new int[3] { 1, 2, 3 };
            //int[] numeri2 = new int[] { 1, 2, 3 };
            /*
            int[] numeri2 = { 1, 2, 3 };
            int[] box = numeri2;
            box[0] = 5;


            Random random = new Random();

            for (int indice = 0; indice < numeri.Length; indice++)
            {
                numeri[indice] = random.Next(99) + 1;
            }

            foreach (var element in numeri2) {
                Console.WriteLine(element);
            }
            */

            int[] numericasuali;
            Casuale(out numericasuali, 5);

            VisualizzaVettore(numericasuali);

            inverti(numericasuali);

            VisualizzaVettore(numericasuali);

            Console.ReadLine();
        }
        static void Casuale(out int[] vettore, int elementi)
        {
            Random numero = new Random();
            vettore = new int[elementi];

            for (int indice = 0; indice < vettore.Length; indice++)
            {
                vettore[indice] = numero.Next(99) + 1;
            }

        }
        static void VisualizzaVettore(int[] vettore)
        {
            foreach (var item in vettore)
            {
                Console.WriteLine(item);
            }
        }

        static void inverti(int[] vettore)
        {
            int[] invertito = new int[vettore.Length];
            Console.WriteLine("Inversione......");
            for (int x = 0; x < vettore.Length; x++)
            {
                invertito[x] = vettore[vettore.Length - x - 1];
            }
            for (int x = 0; x < vettore.Length; x++)
            {
                vettore[x] = invertito[x];
            }
        }

    }
}
