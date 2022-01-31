using System;

namespace Labb_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter boken?");
            string titel = Console.ReadLine();
            Console.WriteLine("Vem skrev boken?");
            string författare = Console.ReadLine();
            Console.WriteLine("Hur lång är boken?");
            int antalsidor = ReadInt();
            Bok bok = new Bok(titel, författare, antalsidor);
            bok.Skrivut();
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
