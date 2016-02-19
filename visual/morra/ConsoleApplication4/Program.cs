using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] valori = new string[2][];
            valori[0] = new string[3] { "A", "S", "D" };
            valori[1] = new string[3] { "J", "K", "L" };
            string[] nomi = new string[2];
            string cosa = "";
            string ultimo = "";
            int[] punteggio = new int[2] { 0, 0 };
            int g = 1;

            Console.WriteLine("Ciao!\nBenvenuto al gioco della morra cinese.\nQuesta versione è stata creata da Daniil Gentili.\nLicenza GPLv3.\n\nIl giocatore 1 deve usare i tasti a, s, d\nmentre il giocatore 2 deve usare i tasti j, k, l per\ncarta, sasso, forbici rispettivamente.\nX ferma il gioco.\n");
            Console.Write("Primo giocatore, inserisci il tuo nome: ");
            nomi[0] = Console.ReadLine();
            Console.Write("Secondo giocatore, inserisci il tuo nome: ");
            nomi[1] = Console.ReadLine();

            while (cosa != "X") {
                
                if (g == 1)
                {
                    // giocatore 1
                    g = 0;
                    Console.WriteLine("\nAdesso il punteggio è " + punteggio[0] + "/" + punteggio[1]);
                }
                else
                {
                    // giocatore 2
                    g = 1;
                }
                Console.Write("È il tuo turno " + nomi[g] + ": ");
                cosa = Console.ReadKey(true).Key.ToString();
                Console.WriteLine();
                if (cosa != "X")
                {
                    if (Array.IndexOf(valori[g], cosa) > -1)
                    {
                        if(g == 0) { ultimo = cosa; } else { 
                            if (ultimo+cosa == "AK" || ultimo+cosa == "SL" || ultimo+cosa == "DJ") {
                                punteggio[0]++;
                            } else if (ultimo+cosa == "AJ" || ultimo+cosa == "SK" || ultimo+cosa == "DL") {
                                punteggio[0]++;
                                punteggio[1]++;
                            } else {
                                punteggio[1]++;
                            }
                            ultimo = "";
                        };
                    } else {
                        Console.WriteLine("Hai inserito un valore errato. Questa partita è stata annullata.");
                        g = 1;
                        ultimo = "";
                    }
                }
            }
            Console.WriteLine("\Il punteggio finale è " + punteggio[0] + "/" + punteggio[1] + "\nCiao ciao!");
            Console.ReadKey();
        }
    }
}
