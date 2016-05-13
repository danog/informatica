using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chartest
{
    class Program
    {
        static void Main(string[] args)
        {
            int wut;
            while (true)
            {
                wut = Convert.ToInt32(Console.ReadKey().KeyChar);
                Console.WriteLine("\n"+wut);
            }
        }
    }
}
