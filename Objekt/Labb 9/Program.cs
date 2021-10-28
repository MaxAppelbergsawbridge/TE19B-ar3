using System.Collections.Generic;
using System;

namespace Labb_9
{
    class NamnAdress
    {
        public string förnamn = "";
        public string efternamn = "";
        public string gatuadress = "";
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<NamnAdress> lista = new List<NamnAdress>();

            while (true)
            {
                NamnAdress objekt = new NamnAdress();
                Console.WriteLine("Vad är ditt förnamn?");
                objekt.förnamn = Console.ReadLine();
                if (objekt.förnamn == "")
                {
                    break;
                }
                System.Console.WriteLine("Vad är ditt efternamn");
                objekt.efternamn = Console.ReadLine();
                Console.WriteLine("Vad är din gatuadress");
                objekt.gatuadress = Console.ReadLine();
                lista.Add(objekt);
                foreach (var item in lista)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
