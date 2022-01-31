using System;

namespace Labb_14
{
    public class Bok
    {
        private string Titel { get; set; }
        private string Författare { get; set; }
        private int Antalsidor { get; set; }
        public void Skrivut()
        {
            Console.WriteLine($"Boken är {Titel} av {Författare}, den är {Antalsidor} sidor lång");
        }

        public Bok(string _titel, string _författare, int _antalsidor)
        {
            Titel = _titel;
            Författare = _författare;
            Antalsidor = _antalsidor;
        }
    }
}