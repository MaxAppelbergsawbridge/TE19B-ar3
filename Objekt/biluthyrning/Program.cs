using System;
using System.Collections.Generic;

namespace Ny_mapp
{
    class Program
    {
        //kostand för bilarna
        //Volvo ABC123 -> 500:-/d
        //Saabb DEF 456 -> 400 :-/d
        //Fiat GHI 789 -> 199:-/d
        //extra km =2:-/d
        static List<avtal> ListAvAvtal = new List<avtal>();
        static void Main(string[] args)
        {
            string svar = "j";
            while (svar == "j")
            {
                List<avtal> AllaAvtal = new List<avtal>();
                avtal avtal = new avtal();
                ListAvAvtal.Add(avtal);
                Console.WriteLine("Välkommen till biluthyrning!");
                Console.WriteLine("Ange kundens personnr");
                avtal.Personnr = Console.ReadLine();
                Console.WriteLine("Ange bilen regnr");
                avtal.RegNr = Console.ReadLine();
                while (!avtal.finnsRegnr())
                {
                    Console.WriteLine("Ange bilen regnr");
                    avtal.RegNr = Console.ReadLine();
                }
                Console.WriteLine("Ange antal Km");
                avtal.Km = int.Parse(Console.ReadLine());
                Console.WriteLine("Ange antal dygn");
                avtal.Tidsram = int.Parse(Console.ReadLine());
                //Räkna ut kostnaden
                Console.WriteLine($"Total hyran blir {avtal.RäknaKostnad()} kr");

                Console.WriteLine($"Bilen skall åter{avtal.Räknainlämningsdatum()}");
                Console.WriteLine("vill du mäta in ett till avtal");
                svar = Console.ReadLine().ToLower();

            }

        }
    }
}
