using System;

namespace intro_arv
{
    class Person
    {
        public Person(string namn, string mobil)
        {
            Namn = namn;
            Mobil = mobil;
        }
        public string Namn { get; set; }
        public string Mobil { get; set; }
        public virtual void VisaInfo()
        {
            Console.WriteLine($"Namn:{Namn},Mobil:{Mobil}");
        }
    }
    class Student : Person
    {
        public string Årskurs { get; set; }
        public string Linje { get; set; }
        public Student(string n, string m, string årskurs, string linje) : base(n, m)
        {
            Årskurs = årskurs;
            Linje = linje;
        }

        public override void VisaInfo()
        {
            Console.WriteLine($"Namn:{Namn},Mobil:{Mobil}");
            Console.WriteLine($"Årskurs:{Årskurs},Program:{Linje}");
        }
    }
    class Lärare : Person
    {
        public string Anställningsår { get; set; }
        public string Ämnen { get; set; }
        public Lärare(string n, string m, string anställningsår, string ämnen) : base(n, m)
        {
            Anställningsår = anställningsår;
            Ämnen = ämnen;
        }
        public override void VisaInfo()
        {
            Console.WriteLine($"Namn:{Namn},Mobil:{Mobil}");
            Console.WriteLine($"AnställningsÅr:{Anställningsår},Ämnen:{Ämnen}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv - registera personer på skolan");

            while (true)
            {
                //skapa en instans (objekt)
                Student student = new Student();
                Console.WriteLine("Vad heter personen");
                student.Namn = Console.ReadLine();

                Console.WriteLine("Vad är personens mobilnr");
                student.Mobil = Console.ReadLine();
                Console.WriteLine("mäta en till(j/n)");
                Console.WriteLine("Ange årskurs");
                student.Årskurs = Console.ReadLine();

                Console.WriteLine("Ange program");
                student.Linje = Console.ReadLine();
                student.VisaInfo();
                Console.WriteLine("mäta en till(j/n)");
                if (Console.ReadLine() != "j")
                {
                    break;
                }
            }
        }
    }
}
