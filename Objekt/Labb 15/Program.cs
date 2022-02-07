using System;

namespace Labb_15
{
    class Program
    {

        static void Main(string[] args)
        {
            Tärning tärning = new Tärning();
            Console.WriteLine(kasta(tärning.Tärningssidor));
        }
        static int kasta(int Antalsidor)
        {
            var rand = new Random();
            int resultat = rand.Next(Antalsidor);
            return resultat;
        }
    }
}
