using System;

namespace labb_18
{
    public class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        protected string Name { get; set; }
        public Creature(string name)
        {
            Name = name;
        }
        public string GetInfo()
        {
            Console.WriteLine("Which creature is this?");
            string CreatrName = Console.ReadLine();
            Console.WriteLine("How much hp does the creature have?");
            string CreatrHealth = Console.ReadLine();
            Console.WriteLine("How much shield does the creature have?");
            string CreatrShield = Console.ReadLine();
            return CreatrName + CreatrHealth + CreatrShield;
        }
    }
    public class Knight : Creature
    {
        protected string Weapon { get; set; }
        public Knight(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }
        public void Attack()
        {
            Console.WriteLine($"Knight{Name}Attacks with{Weapon}");
        }
    }
    public class Dragon : Creature
    {
        protected string Color { get; set; }
        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }
        public void Attack()
        {
            Console.WriteLine($"{Color}dragon{Name}attacks with fire");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
