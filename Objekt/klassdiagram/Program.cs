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
                //ange namn
                Console.WriteLine("Räkna ut lönekostnad");
                Console.WriteLine("Vad heter anställd");
                person.namn = Console.ReadLine();
                if (person.namn == "")
                {
                    break;
                }
                //ange timlön
                Console.WriteLine("Vad är timlönen");
                person.timlön = ReadInt();
                Console.WriteLine("Den anställdes arbetstid");
                person.timmar = ReadInt();
                //lagra i listan
                listaperson.Add(person);
            }
            //spara ned som json
            string json = JsonConvert.SerializeObject(listaperson, Formatting.Indented);
            File.WriteAllText(@"listaperson.json", json);
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
