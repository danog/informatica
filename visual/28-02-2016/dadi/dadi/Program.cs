using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadi
{
    class Program
    {
        static void centerprint(string input) // Scrivi al centro dello schermo
        {
            Console.SetCursorPosition((Console.WindowWidth - input.Length) / 2, Console.CursorTop);
            Console.WriteLine(input);
        }
        static int tryreadint() // Prova a leggere un int
        {
            bool ripeti = true;
            int input = 0;
            const long errorletter = -2146233033; // inserimento lettere
            const long error2big = -2146233066; // inserimento numero out range

            do // Ripeti finché non si inserisce un numero corretto
            {

                try
                {
                    input = Convert.ToInt32(Console.ReadLine()); // Converti in int
                    ripeti = false; // Se ok interrompi il loop
                }

                catch (Exception msg) // gestione errori
                {
                    if (msg.HResult == error2big)
                    {
                        Console.Write("Numero inserito troppo grande, reinserire il numero: "); 
                        ripeti = true;
                    }
                    else if (msg.HResult == errorletter)
                    {
                        Console.Write("Non hai inserito un numero, reinserire il numero: ");
                        ripeti = true;
                    }
                }
            } while (ripeti);
            return input;
        }
        static void dado(int d) // Scrivi i dadi
        {
            switch (d)
            {
                    case 1:
                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint("||    O    ||");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....
                        break;

                    case 2:
                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint("||  O   O  ||");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....
                        break;
                    case 3:
                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint("||  O O O  ||");
                        centerprint("||         ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....
                        break;

                    case 4:

                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||  O   O  ||");
                        centerprint("||         ||");
                        centerprint("||  O   O  ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....
                        break;

                    case 5:

                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||  O   O  ||");
                        centerprint("||    O    ||");
                        centerprint("||  O   O  ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 6:

                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||  O   O  ||");
                        centerprint("||  O   O  ||");
                        centerprint("||  O   O  ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....

                        break;
                    default:
                        Console.Clear(); // Elimina dalla faccia del terminale ciò che c'era scritto
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||  ?????  ||");
                        centerprint("||  ?????  ||");
                        centerprint("||  ?????  ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000); // ZZZZZZZZ....

                        break;
            }



        }

        static void Main(string[] args)
        {
            int g = 1; // Giocatore corrente
            string[] nomi = new string[2]; // Nomi dei giocatori
            bool end = false; // Ripeti finchè non si preme 3
            bool ok = true; // se true fai la partita
            int volte = 0; // Numero di turni
            int input = 0; // Input del menù
            int[] punteggio = new int[2] { 0, 0 }; // Matrice del punteggio
            int[] temp = new int[2]; // Matrice della somma dei numeri che sono usciti
            int[] tempvolte = new int[2]; // Matrice del numero di volta
            Random n = new Random(); // RANDOMMMMMMMMMMMMMMMMM
            int v = 0; // per il loop for
            
            // Benvenuti!
            Console.WriteLine("Benvenuto al gioco dei dadi.\n\nQuesta versione è stata creata da Daniil Gentili.\n\nLicenza GPLv3.\n\n");

            while (end == false){ // Ripeti finchè non si preme 3
                // Il menù
                Console.Write("\nAdesso il punteggio è: "+punteggio[0]+"/"+punteggio[1]+"\n1. Duello tra giocatori.\n2. Duello con il computer.\n3. Esci dal gioco.\nSeleziona la modalità di gioco: ");
                input = tryreadint(); // Prova a leggere l'input
                
                if (input == 3) // Esci se viene inserito 3
                {
                    end = true; // Interrompi il loop principale
                    ok = false; // Non eseguire la parte funzionale
                }
                else if (input == 1) // Turni
                {
                    Console.Write("Giocatore 1, inserisci il tuo nome: ");
                    nomi[0] = Console.ReadLine(); // Assegna i valori
                    Console.Write("Giocatore 2, inserisci il tuo nome: ");
                    nomi[1] = Console.ReadLine(); // Assegna i valori
                    Console.Write("Inserire il numero di lanci desiderato per questa partita: ");
                    volte = tryreadint(); // Leggi il numero di turni
                    ok = true; // Puoi eseguire la parte funzionale
                }
                else if (input == 2)
                {
                    Console.Write("Giocatore 1, inserisci il tuo nome: ");
                    nomi[0] = Console.ReadLine();
                    nomi[1] = "Computer";
                    volte = 5; // Numero di turni
                    ok = true; // Puoi eseguire la parte funzionale
                }
                else
                {
                    Console.WriteLine("Hai inserito un valore invalido.\nRiprovare.");
                    ok = false; // Non eseguire la parte funzinoale
                }
                volte = volte * 2; // Numero di turni

                if (end == false && ok == true)
                {
                    for (v = 1; v <= volte; v++) // Quanti lanci
                    {
                        if (g == 1) // Scambia i giocatori
                        {
                            g = 0;
                        }
                        else
                        {
                            g = 1;
                        }

                        if (input == 2 && g == 1) // Se la modalità di gioco è 2 ed è il turno del computer
                        {
                            Console.WriteLine("È il mio turno.");
                            System.Threading.Thread.Sleep(1000);

                        }
                        else
                        {
                            Console.Write("È il tuo turno " + nomi[g] + ", premi un tasto per lanciare il dado: ");
                            Console.ReadKey();
                        }


                        for (int d = 1; d <= 6; d++)
                        {
                            dado(d);
                        }
                        int numero = n.Next(1, 7);
                        dado(numero);
                        Console.WriteLine("È uscito un " + numero + ".");
                        System.Threading.Thread.Sleep(1000);

                        temp[g] += numero;
                        tempvolte[g]++;
                        // Dopo faccio la media
                    }
                    if (temp[0] / tempvolte[0] > temp[1] / tempvolte[1])
                    {
                        punteggio[0]++;
                        Console.WriteLine("Questa partita è stata vinta da: "+nomi[0]);

                    }
                    else if (temp[0] / tempvolte[0] == temp[1] / tempvolte[1])
                    {
                        punteggio[0]++;
                        punteggio[1]++;
                        Console.WriteLine("Avete fatto pari!");
                    }
                    else
                    {
                        punteggio[1]++;
                        Console.WriteLine("Questa partita è stata vinta da: " + nomi[1]);

                    }
                    // Resetta tutto
                    temp[0] = 0;
                    temp[1] = 0;
                    tempvolte[0] = 0;
                    tempvolte[1] = 0;

                }
            }
            Console.WriteLine("Il punteggio finale è "+punteggio[0]+"/"+punteggio[1]);
            Console.ReadKey();
        }
    }
}
