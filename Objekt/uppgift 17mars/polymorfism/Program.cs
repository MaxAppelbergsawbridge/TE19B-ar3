using System;

namespace polymorfism
{
    class Program
    {
        abstract class Creature
        {
            public Creature()
            {
                Console.WriteLine("A creature was created");
            }
            public abstract void Saysomething();
        }
        class Wizard : Creature
        {
            public override void Saysomething()
            {
                Console.WriteLine("Wizard says hi");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
