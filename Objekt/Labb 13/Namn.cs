using System;

namespace Labb_13
{
    public class Namn
    {
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public DateTime Födelseår { get; set; }
        public bool Myndig()
        {
            DateTime Now = DateTime.Now;
            int age = Now.Year - Födelseår.Year;
            if (age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Visanamn()
        {
            Console.WriteLine(Förnamn + " " + Efternamn);
        }
    }
}