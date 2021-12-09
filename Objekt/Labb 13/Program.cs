using System;

namespace Labb_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv ditt förnamn");
            Namn person = new Namn();
            person.Förnamn = Console.ReadLine();
            Console.WriteLine("skriv ditt efternamn");
            person.Efternamn = Console.ReadLine();
            Console.WriteLine("vilket år var du född?");
            person.Födelseår = DateTime.Parse(Console.ReadLine());
            if (person.Myndig())
            {
                Console.WriteLine("Du är myndig");
            }
            else
            {
                Console.WriteLine("Du är inte myndig");
            }
            person.Visanamn();
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
