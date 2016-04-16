using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprPassaggio
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] random;

            Random1(out random);

            PrintArray(random);
            Console.WriteLine("=======================");
            Random2(ref random, 20);
            PrintArray(random);
            Console.ReadLine();
        }
        static void Random(int[] random) // Se si passa per valore il riferimento deve riferire ad un array preesistente
        {
            Random num = new Random();
            for (int i = 0; i < random.Length; i++) {
                random[i] = num.Next(100);
            }
        }

        static void Random1(out int[] random)// Se si passa per out il riferimento può anceh non puntare ad un array preesistente
        {
            random = new int[10];
            Random num = new Random();
            for (int i = 0; i < random.Length; i++)
            {
                random[i] = num.Next(100);
            }
        }


        static void Random2(ref int[] random, int slongamelo)// Se si passa per ref il riferimento
        {
            int[] box = new int[random.Length + slongamelo];
            for (int i = 0; i < random.Length; i++)
            {
                box[i] = random[i];
            }
            random = box;
        }

        static void PrintArray(int[] ran)
        {
            for (int i = 0; i < ran.Length; i++)
            {
                Console.WriteLine("Il {0}^ valore dell'array è {1}.", i, ran[i]);
            }
        }
        static void Intero(ref int val1)
        {
            ConsoleKey.
            int val2 = 5;
            val1 = val2;
        }

    }
}
