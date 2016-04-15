using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dadi
{
    class Program
    {
        static void centerprint(string input) // scrivi al centro dello schermo
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

            do // Ripeti finché non si inserisce un numero
            {

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    ripeti = false;
                }

                catch (Exception msg)//gestione errore 
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
        static void fiammifero(int d) // Scrivi i fiammiferi
        {
            switch (d)
            {
                    case 1:
                        Console.Clear();
                        centerprint("O");
                        centerprint("|");
                        centerprint("|");
                        centerprint("|");
                        centerprint("|");
                        centerprint("|");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case 2:
                        Console.Clear();
                        centerprint("O O");
                        centerprint("| |");
                        centerprint("| |");
                        centerprint("| |");
                        centerprint("| |");
                        centerprint("| |");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case 3:
                        Console.Clear();
                        centerprint("O O O");
                        centerprint("| | |");
                        centerprint("| | |");
                        centerprint("| | |");
                        centerprint("| | |");
                        centerprint("| | |");
                        System.Threading.Thread.Sleep(1000);
                        break;

                    default:


                        Console.Clear();
                        centerprint(" =========== ");
                        centerprint("||         ||");
                        centerprint("||  ?????  ||");
                        centerprint("||  ?????  ||");
                        centerprint("||  ?????  ||");
                        centerprint("||         ||");
                        centerprint(" =========== ");
                        System.Threading.Thread.Sleep(1000);
                        break;
            }



        }

        static void Main(string[] args)
        {

            int g = 1; // Giocatore corrente
            string[] nomi = new string[2]; // Nomi dei giocatori
            bool end = false; // Ripeti finchè non si preme 3
            bool ok = true; // se true fai la partita
            bool estrazioneok = false; // se false reinsersci il numero di fiammiferi che vuoi estrarre
            int input = 0; // Ciò che inserisce l'utente
            int[] punteggio = new int[2] { 0, 0 }; // Il punteggio
            
            int somma = 0; // il numero di fiammiferi che vengono estratti viene sommato qui
            int estrazione = 0; // Quanti fiammiferi vengono estratti
            Random n = new Random(); // Random

            Console.WriteLine("Benvenuto al gioco dei fiammiferi.\n\nQuesta versione è stata creata da Daniil Gentili.\n\nLicenza GPLv3.\n\n");

            while (end == false){ // Ripeti finchè non si preme 3
                
                Console.Write("\nAdesso il punteggio è: "+punteggio[0]+"/"+punteggio[1]+"\n1. Duello tra giocatori.\n2. Duello con il computer.\n3. Esci dal gioco.\nSeleziona la modalità di gioco: ");
                input = tryreadint(); // selezione del menù
                
                if (input == 3)
                {
                    end = true;
                    ok = false;
                }
                else if (input == 1)
                {
                    Console.Write("Giocatore 1, inserisci il tuo nome: ");
                    nomi[0] = Console.ReadLine();
                    Console.Write("Giocatore 2, inserisci il tuo nome: ");
                    nomi[1] = Console.ReadLine();
                    ok = true;
                }
                else if (input == 2)
                {
                    Console.Write("Giocatore 1, inserisci il tuo nome: ");
                    nomi[0] = Console.ReadLine();
                    nomi[1] = "Computer";
                    ok = true;
                }
                else
                {
                    Console.WriteLine("Hai inserito un valore invalido.\nRiprovare.");
                    ok = false;
                }

                if (end == false && ok == true) // Se è stato inserito un valore ok
                {
                    while ((21 - somma) > 0) // I fiammiferi sono finiti?
                    {
                        if (g == 1) // Scambio giocatore
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

                            estrazioneok = false;
                            while (estrazioneok == false)
                            {
                                estrazione = n.Next(1, 4);
                                if (estrazione >= 1 && estrazione <= 3 && somma + estrazione <= 21)
                                {
                                    estrazioneok = true;
                                }
                                else
                                {
                                    Console.Write("Hai inserito un numero errato. Prego riprovare: ");
                                }
                            }

                        }
                        else
                        {
                            Console.Write("È il tuo turno " + nomi[g] + ", quanti fiammiferi vuoi estrarre (ricorda, puoi estrarre da 1 a 3 fiammiferi per volta): ");
                            
                            estrazioneok = false;
                            while (estrazioneok == false){
                                estrazione = tryreadint();
                                if (estrazione >= 1 && estrazione <= 3 && somma + estrazione <= 21)
                                {
                                    estrazioneok = true;
                                }
                                else
                                {
                                    Console.Write("Hai inserito un numero errato. Prego riprovare: ");
                                }
                            }
                        }


                        somma += estrazione;

                        fiammifero(estrazione);
                        Console.WriteLine("Sono stati estratti " + estrazione + " fiammiferi dal mazzo, ne rimangono " + (21 - somma));

                        System.Threading.Thread.Sleep(1000);
                    }
                    punteggio[g]++;
                    Console.WriteLine("Questa partita è stata vinta da: "+nomi[g]);
                    somma = 0;
                    estrazione = 0;
                }
            }
            Console.WriteLine("Il punteggio finale è "+punteggio[0]+"/"+punteggio[1]);
            Console.ReadKey();
        }
    }
}

