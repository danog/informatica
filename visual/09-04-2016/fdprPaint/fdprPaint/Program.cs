using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdprPaint
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("L'altezza della finestra è: {0}", Console.WindowHeight);
            //Console.WriteLine("L'larghezza della finestra è: {0}", Console.WindowWidth);
            int x = 0;
            int y = 0;
            char matita = '.';


            Console.ReadLine();
        }
        static void printTo(int x, int y, char print)
        {

            Console.SetCursorPosition(x, y);
            Console.Write(print);
            Console.SetCursorPosition(x, y);
        }
    }
}
