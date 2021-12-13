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
            double age = 0;
            age = DateTime.Now.Subtract(Födelseår).Days;
            age = age / 365.25;
            DateTime Now = DateTime.Now;
            Console.WriteLine(age);
            if (age > 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Längd { get; set; }
        public int Vikt { get; set; }   
        public int BMI()
        {
            return Vikt / Längd * Längd;
        }
        public void Visanamn()
        {
            Console.WriteLine(Förnamn + " " + Efternamn);
        }
    }
}