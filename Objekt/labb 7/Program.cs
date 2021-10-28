using System.Collections.Generic;
using System;

namespace labb_7
{
    class PersonInkomst
    {
        public string namn = "";
        public int Lön = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program för att registera löner");
            //lagra uppgifter i ett objekt
            PersonInkomst objekt = new PersonInkomst();
            List<PersonInkomst> lista = new List<PersonInkomst>();
            while (true)
            {
                //ange namn och lön
                Console.WriteLine("ange ditt namn");
                objekt.namn = Console.ReadLine();
                if (objekt.namn == "")
                {
                    break;
                }
                Console.WriteLine($"Ange din månadslön");
                objekt.Lön = ReadInt();
            }
            lista.Add(objekt);
        }
        /// <summary>
        /// Läser int och kontrollerar dem
        /// </summary>
        /// <returns></returns>
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
