using System;

namespace klassdiagram
{
    public class PersonInkomst
    {
        public string Namn { get; set; }//skyddar variablen genom att göra den till en metod
        public int Lön { get; set; }//skyddar variablen genom att göra den till en metod
        public int Timmar { get; set; }//skyddar variablen genom att göra den till en metod

        //Klass metod
        public void Visatimlön()
        {
            Console.WriteLine($"{Namn} din timlön är {Lön / Timmar}");
        }
    }
}