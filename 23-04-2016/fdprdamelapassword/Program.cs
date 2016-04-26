using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace fdprdamelapassword
{
    class Program
    {
        static void Main(string[] args)
        {
            /* creare due metodi: il primo data una stringa di 8 caratteri e un codice di criptazione creare la password
             * data la password criptata redeterminare la password originale con il codfice di cripatzione
             * bancomat se la password è giusta allora ok
            */
            int exit = 0;
            string secret = "";
            do
            {
                try
                { 
                    Console.WriteLine("Benvenuti nel programma di accesso Bancomat creato da Daniil Gentili.\nLicenza GPLv3.\n");

                    Console.WriteLine("1. Crea la password di accesso e il codice casuale.\n2. Entra nel bancomat.\n3. Esci.\n");

                    Console.Write("La tua scelta: ");
                    exit = Convert.ToInt32(Console.ReadLine());
                    switch (exit)
                    {
                        case 1:
                            secret = askencrypt();
                            break;
                        case 2:
                            if(secret == askdecrypt()){
                                Console.WriteLine("I dati inseriti sono corretti. Accesso consentito.");                                
                            } else {
                                Console.WriteLine("I dati inseriti sono errati. Prego riprovare.");

                            }

                            break;
                    }
                }
                catch (Exception)
                {
                }

                Console.ReadKey();
                Console.Clear();
            } while (exit != 3);




            Console.ReadKey();
        }

        static string askdecrypt()
        {

            Console.Write("Inseire la stringa encriptata: ");
            string encrypted = Console.ReadLine();
            Console.Write("Inserire la chiave casuale: ");
            string key = Console.ReadLine();
            Console.WriteLine("Sto decrittando il tutto....");
            return decrypt(encrypted, key);
        }
        static string askencrypt()
        {

            string stringa = leggifermati("Inserire la stringa da encriptare (codice alfanumerico di 8 caratteri): ", 8);
            Console.WriteLine("Sto generando la chiave casuale....");
            string key = GetUniqueKey(stringa.Length);
            Console.WriteLine("Sto encriptando il tutto....");
            string encrypted = encrypt(stringa, key);
            Console.WriteLine("La stringa casuale è {0} e la stringa encriptata è {1}", key, encrypted);
            return encrypted;
        }
        static string encrypt(string data, string key)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int num;
            string result = "";
            for (int x = 0; x < data.Length; x++)
            {
                num = findstring(alfabeto, data[x]) + findstring(alfabeto, key[x]);
                if (num > alfabeto.Length) num -= alfabeto.Length;
                result += alfabeto[num - 1];
            }
            return result;
        }

        static string decrypt(string encrypted, string key)
        {

            string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int num;
            string result = "";
            for (int x = 0; x < encrypted.Length; x++)
            {
                num = findstring(alfabeto, encrypted[x]) - findstring(alfabeto, key[x]);
                if (num < 0) num -= alfabeto.Length;
                result += alfabeto[num - 1];
            }
            return result;
        }
        static string leggifermati(string cosa, int dove)
        {

            Char input = '\0';
            string concat = "";
            Console.Clear();
            Console.Write(cosa); // Scrivi messaggio
            Console.BackgroundColor = ConsoleColor.Gray; // Cambia colore di sfondo e colore principale
            Console.ForegroundColor = ConsoleColor.Black;
            for (int x = 1; x < dove; x++)
            {
                Console.Write(" ");
            }
            Console.SetCursorPosition(cosa.Length, Console.CursorTop);
            for (int x = 0; x < dove; x++)
            {
                input = '\0';
                while (!char.IsLetterOrDigit(input))
                {
                    input = Console.ReadKey(true).KeyChar; // A = 65, Z = 90,a = 97, z = 122
                }

                if (input == '\b')
                {
                    if (x != 1)
                    {
                        x--;
                        concat = concat.Remove(concat.Length - 1);
                    }

                }
                else
                {
                    Console.Write(input);
                    concat += input.ToString();
                }
            }
            Console.ResetColor();
            return concat;
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[1];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetNonZeroBytes(data);
                data = new byte[maxSize];
                crypto.GetNonZeroBytes(data);
            }
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }
        static int findstring(string wut, char find)
        {
            int num = 0;
            for (int x = 0; x < wut.Length; x++)
            {
                if (wut[x] == find)
                {
                    num = x + 1;
                }
            }
            return num;
        }
    }
}
