using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprProvaEsperta1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel programma dei numeri casuali.");
            int n = tryreadint("Dimmi quanti numeri casuali devo generare: ");
            int[] nums = mkrandom(n);
            int[] maxminmed = getmaxminmed(nums);
            Console.WriteLine();
            Console.WriteLine("Il numero più grande è {0}, il numero più piccolo è {1} e la media è {2}", maxminmed[0], maxminmed[1], maxminmed[2]);
            Console.WriteLine();
            uniq(nums);
            Console.ReadKey();
        }
        static int[] mkrandom(int n)
        {
            Random numeroCasuale = new Random();
            int[] num = new int[n];
            for (int x = 0; x < num.Length; x++)
            {
                num[x] = numeroCasuale.Next(100) + 1;
            }
            return num;
        }

        static int[] getmaxminmed(int[] num)
        {
            int[] maxminmed = { 0, 101, 0 }; // 0 = max, 1 = min, 2 = med
            for (int x = 0; x < num.Length; x++)
            {
                if (num[x] > maxminmed[0]) maxminmed[0] = num[x];
                if (num[x] < maxminmed[1]) maxminmed[1] = num[x];
                maxminmed[2] += num[x];
            }
            maxminmed[2] /= num.Length;
            return maxminmed;
        }

        static void uniq(int[] num)
        {
            Console.Write("Ecco i valori del vettore senza ripetizioni: ");
            List<int> uniq = new List<int>();
            for (int x = 0; x < num.Length; x++)
            {
                if (!uniq.Contains(num[x])) uniq.Add(num[x]);
            }

            for (int x = 0; x < uniq.Count; x++)
            {
                Console.Write(uniq[x]);
                if (x != uniq.Count - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
        static int tryreadint(string wut)
        {
            bool notok = true;
            int num = 0;
            do
            {
                try
                {
                    Console.Write(wut);
                    num = Convert.ToInt32(Console.ReadLine());
                    notok = false;
                }
                catch (Exception)
                {
                    notok = true;
                }
            } while (notok);
            return num;
        }
    }
}
