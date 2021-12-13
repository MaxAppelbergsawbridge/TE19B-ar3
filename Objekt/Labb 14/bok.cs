using System;

namespace Labb_14
{
    public class bok
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int Antalsidor { get; set; }
        public void Skrivut()
        {
            Console.WriteLine($"Boken är {Titel} av{Författare}, den är {Antalsidor} lång");
        }
    }
}