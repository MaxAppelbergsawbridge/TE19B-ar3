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
            Console.WriteLine("När var du född?(dd-mm-yyyy)");
            person.Födelseår = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Hur mycket väger du?");
            person.Vikt = ReadInt();
            Console.WriteLine("Hur lång är du?");
            person.Längd = ReadInt();
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
        public double GetAge(DateTime Födelseår)
        {
            double age = 0;
            age = DateTime.Now.Subtract(Födelseår).Days;
            age = age / 365.25;
            return age;
        }
    }
}
