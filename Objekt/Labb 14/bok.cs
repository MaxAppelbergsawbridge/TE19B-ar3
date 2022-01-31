using System;

namespace Labb_14
{
    public class bok
    {
        private string Titel { get; set; }
        private string Författare { get; set; }
        private int Antalsidor { get; set; }
        public void Skrivut()
        {
            Console.WriteLine($"Boken är {Titel} av{Författare}, den är {Antalsidor} lång");
        }
        public void LäsInTitel()
        {
            Console.WriteLine("Vad heter boken?");
            Titel = Console.ReadLine();
        }
        public void LäsInFöfattaren()
        {
            Console.WriteLine("Vad heter författaren?");
            Författare = Console.ReadLine();
        }
        public void LäsInAntalSidor()
        {
            Console.WriteLine("Hur lång är boken?");
            Antalsidor = ReadInt();
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