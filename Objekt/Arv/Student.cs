using System;

namespace Arv
{
    public class Student : Person
    {
        public string Inskrivningsår { get; set; }
        public bool BetaldKåravgift { get; set; }

        public void VisaStudentInfo()
        {
            Console.WriteLine($"Namn: {Namn}, mobil: {Mobil}, inskrivningsår: {Inskrivningsår}");
            if (BetaldKåravgift)
            {
                Console.WriteLine("Kåravgiften är betald!");
            }
        }
    }
}