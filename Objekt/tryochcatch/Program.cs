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
                    Console.WriteLine("Du måste mata in två tal");
                }
                //
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
