using System;

namespace Arv
{
    public class Person
    {

        public string Namn { get; set; }
        public string Mobil { get; set; }

        public void VisaInfo()
        {
            Console.WriteLine($"Namn: {Namn}, mobil: {Mobil}");
        }
    }
}