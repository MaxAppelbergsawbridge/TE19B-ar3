using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace klassdiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonInkomst> listaperson = new List<PersonInkomst>();
            while (true)
            {
                //skapa objektet person från klassen Personinkomst 
                PersonInkomst person = new PersonInkomst();
                //ange Namn
                Console.WriteLine("Räkna ut lönekostnad");
                Console.WriteLine("Vad heter anställd");
                person.Namn = Console.ReadLine();
                if (person.Namn == "")
                {
                    break;
                }
                //ange timlön
                Console.WriteLine("Vad är lönen");
                person.Lön = ReadInt();
                Console.WriteLine("Den anställdes arbetstid");
                person.Timmar = ReadInt();
                //lagra i listan
                listaperson.Add(person);
            }
            int antaltimmar = 0;
            int avgifter = 0;
            foreach (var item in listaperson)
            {
                antaltimmar += item.Timmar;
                avgifter += item.Lön;
                item.Visatimlön();
            }
            Console.WriteLine("dina arbetare har jobbat" + antaltimmar + "timmar");
            Console.WriteLine("du har betalat" + avgifter + "kr i avgifter");

            //spara ned som json
            string json = JsonConvert.SerializeObject(listaperson, Formatting.Indented);
            File.WriteAllText(@"listaperson.json", json);
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
}
