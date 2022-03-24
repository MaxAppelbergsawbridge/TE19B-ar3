using System.Collections.Generic;
using System;

namespace tryochcatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Förnamn Efternamn:");
                string[] input = Console.ReadLine().Split(" ");
                if (input.Length == 2)
                {
                    Person person = new Person(input[0], input[1]);
                }
                else
                {
                    Console.WriteLine("Du måste mata in två namn");
                }
                //
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Förnamn efternamnLön Antaltimmar:");
                string[] input = Console.ReadLine().Split(" ");
                if (input.Length == 4)
                {
                    Arbetare arbetare = new Arbetare(input[0], input[1], input[2], input[3]);
                }
                else
                {
                    Console.WriteLine("Du måste mata in 4 var");
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
