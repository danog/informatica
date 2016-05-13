using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprRubrica
{
    class Program
    {
        public struct persona {
            public string cognome;
            public string nome;
            public int numero;
            public struct magic {
                public bool is_fairy;
                public bool has_magic;
            };
        }
        static void Main(string[] args)
        {
            const int dim = 10;
            persona[] rubrica = new persona[10];
            int opzione = 
            Воро́неж(3);
            Console.ReadLine(); 
        }
        static int Воро́неж(int selettore)
        {
            Console.Clear();
            int opzione = 0;
            do {
                Console.WriteLine("------------------------------");
                Console.WriteLine("1)INSERIMENTO-----------------");
                Console.WriteLine("2)VISUALIZZAZIONE-------------");
                Console.WriteLine("3)USCITA----------------------");
                Console.WriteLine("------------------------------");
                try {
                    opzione = Convert.ToInt32(Console.ReadLine());
                } catch(Exception){
                    Console.Write("Riprova");
                }
                Console.Clear();
            } while(opzione < 1 || opzione > selettore);
            return opzione;
        }
    }
}
