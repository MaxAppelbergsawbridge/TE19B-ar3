using System;

namespace uppgift_17mars
{
    class Program
    {
        class Creature
        {
            public int Power { get; set; }
            public int Toughness { get; set; }
            public virtual void Attack()
            {
                Console.WriteLine("Creature attack with power" + Power);
            }
        }
        class Knight : Creature
        {

            public override void Attack()
            {
                Console.WriteLine("Knight attack with power" + Power);
            }
        }
        class Wizard : Creature
        {
            public override void Attack()
            {
                Console.WriteLine("Wizard attack with power");
            }
        }

        static void Main(string[] args)
        {
            Creature wizard = new Wizard();
            Creature knight = new Knight();
            wizard.Attack();
            knight.Attack();
            Console.ReadKey();
        }
    }
}
