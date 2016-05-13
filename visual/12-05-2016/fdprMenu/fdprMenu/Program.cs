using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Avete selezionato l'opzione numero " + menu(new string[] { "Option 1", "Option 2", "Option 3" }));
            Console.ReadKey();
        }
        static int menu(string[] args)
        {
            int returnoption = 0;
            for (int x = 1; x <= args.Length; x++){
                Console.WriteLine(x + ": " + args[x-1]);
            }
            do {
                try {
                    Console.Write("La vostra selezione (1-" + args.Length + "): ");
                    returnoption = Convert.ToInt32(Console.ReadLine());
                    if(returnoption < 1 || returnoption > args.Length) returnoption = 0;
                }catch(Exception e) {
                    Console.WriteLine("Avete selezionato un valore errato! Prego riprovare.");
                    returnoption = 0;
                }
            } while(returnoption < 1 || returnoption > args.Length);
            return returnoption;
        }
    }
}
