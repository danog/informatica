using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprProvaEsperta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma delle stringhe.");
            Console.Write("Dammi una stringa: ");
            string stringa = Console.ReadLine();
            string maiusc = upper(stringa);
            int[] hertz = count(stringa);
            string unico = uniq(stringa);

            Console.WriteLine("La stringa convertita in maiuscolo è: " + maiusc);
            for (int i = 0; i < hertz.Length; i++)
            {
                if (hertz[i] > 0)
                {
                    Console.WriteLine("Carattere {0} frequenza = {1}", Convert.ToChar(i), hertz[i]);
                }
            }
            Console.WriteLine("La stringa senza ripetizioni è: " + unico);
            Console.ReadKey();
        }
        
        static string upper(string stringa)
        {
            string newstring = "";
            for (int x = 0; x < stringa.Length; x++)
            {
                // A = 65, Z = 90,a = 97, z = 122
                if (stringa[x] >= 97 && stringa[x] <= 122)
                {
                    newstring += Convert.ToChar(stringa[x] - 32);
                }
                else newstring += stringa[x];
            }
            return newstring;
        }

        static int[] count(string cosa)
        {
            int[] hertz = new int[1000];
            for (int x = 0; x < cosa.Length; x++)
            {
                hertz[cosa[x]]++;
            }
            return hertz;
        }
        static string uniq(string stringa)
        {
            List<char> uniq = new List<char>();
            string newstring = "";
            for (int x = 0; x < stringa.Length; x++)
            {
                if (!uniq.Contains(stringa[x])) uniq.Add(stringa[x]);
            }
            for (int x = 0; x < uniq.Count; x++)
            {
                newstring += uniq[x];
            }
            return newstring;
        }
    }
}
