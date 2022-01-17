using System;

namespace Ny_mapp
{
    class Program
    {
        //kostand för bilarna
        //Volvo ABC123 -> 500:-/d
        //Saabb DEF 456 -> 400 :-/d
        //Fiat GHI 789 -> 199:-/d
        //extra km =2:-/d
        static void Main(string[] args)
        {
            avtal avtal1 = new avtal();
            Console.WriteLine("Välkommen till biluthyrning!");
            Console.WriteLine("ange kundens personnr");
            avtal1.Personnr = Console.ReadLine();
            Console.WriteLine("Ange bilen regnr");
            avtal1.RegNr = Console.ReadLine();
            Console.WriteLine("Ange antal Km");
            avtal1.Km = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange antal dygn");
            avtal1.Tidsram = int.Parse(Console.ReadLine());
            //Räkna ut kostnaden
            Console.WriteLine($"Total hyran blir {avtal1.RäknaKostnad()} kr");
            Console.WriteLine($"Bilen skall åter{avtal1.Räknainlämningsdatum()}");
        }
    }
}
