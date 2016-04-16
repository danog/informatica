using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lettura_num_lett
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] freq = new int[37];
            int simb;
            do
            {
                simb = Console.Read();//A=65 Z=90 a=97 z=122
                /*Char simb;
                 simb = Convert.Tochar(console.read());*/
                if (simb != 13)
                {
                    if (simb >= 97 && simb <= 122)
                        simb -= 32;
                    if (simb >= 65 && simb <= 90)
                        freq[simb - 55]++;
                    else if (simb >= 48 && simb <= 57)
                        freq[simb - 48]++;
                    else
                        freq[36]++;
                }
            } while (simb != 13);

            for (int i = 0; i < freq.Length -1; i++)
            {
                if (freq[i] > 0 && i < 10)
                    Console.WriteLine("Carattere {0} frequenza = {1}", i, freq[i]);
                else if(freq[i] > 0)
                    Console.WriteLine("Carattere {0} frequenza = {1}", Convert.ToChar(i + 55), freq[i]);
            }
            Console.WriteLine("Gli altri caratteri sono comparsi con frequenza {0}", freq[36]);
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
