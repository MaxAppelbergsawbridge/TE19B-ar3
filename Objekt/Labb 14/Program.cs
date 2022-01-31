using System;

namespace Labb_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bok förslag = new bok();
            förslag.LäsInTitel();
            förslag.LäsInFöfattaren();
            förslag.LäsInAntalSidor();
            förslag.Skrivut();
        }

    }
}
