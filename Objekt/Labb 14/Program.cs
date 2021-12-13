using System;

namespace Labb_14
{
    class Program
    {
        static void Main(string[] args)
        {
            bok förslag = new bok();
            Console.WriteLine("Vad heter boken?");
            förslag.Titel = Console.ReadLine();
            Console.WriteLine("Vad heter författaren?");
            förslag.Författare = Console.ReadLine();
            Console.WriteLine("Hur lång är boken?");
            förslag.Antalsidor = ReadInt();
            förslag.Skrivut();
        }
        static int ReadInt()
        {
            int heltal;
            while (!int.TryParse(Console.ReadLine(), out heltal))
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return heltal;
        }
    }
}
