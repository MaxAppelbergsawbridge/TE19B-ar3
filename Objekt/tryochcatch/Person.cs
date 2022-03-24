using System;
using System.Linq;
namespace tryochcatch
{
    public class Person
    {
        private string förnamn;
        private string Förnamn
        {
            get { return Förnamn; }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("Förnamn måste börja med en versal");
                }
                else
                {
                    förnamn = value;
                }
            }
        }
        private string efternamn;
        private string Efternamn
        {
            get { return efternamn; }
            set
            {
                {
                    if (!char.IsUpper(value[1]))
                    {
                        throw new ArgumentException("Efternamn måste börja med en versal");
                    }
                    //Är förnamnet minst 4 tecken lång
                    else if (value.Length < 4)
                    {
                        throw new ArgumentException("Förnamn måste vara minst 4 tecken långt");
                    }
                    else
                    {
                        efternamn = value;
                    }
                }
            }
        }
        public Person(string förnamn, string efternamn)
        {
            Förnamn = förnamn;
            Efternamn = efternamn;
        }
    }
    class Student : Person
    {
        private string studieprogram;
        public string Studieprogram
        {
            get { return studieprogram; }
            set
            {
                {
                    if (value.ToLower() != "teknik" && value.ToLower() != "estet" && value.ToLower() != "it")
                    {
                        throw new ArgumentException("Ogiltigt studieprogram");
                    }

                    //string[] lista ={"teknik","estet","it"}
                    //if(!lista.Contains(value.Tolower()))
                    //
                    //(using system.linq)
                    //Är förnamnet minst 4 tecken lång
                    else
                    {
                        studieprogram = value;
                    }
                }
            }
        }
        public Student(string förnamn, string efternamn, string studieprogram) : base(förnamn, efternamn)
        {
            Studieprogram = studieprogram;
        }
    }
    class Arbetare : Person
    {
        private int lön;
        private int antaltimmar;
        public int Lön
        {
            get
            { return lön; }
            set
            {
                if (value >= 0 && value <= 20000)
                {
                    lön = value;
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }
        public int Antaltimmar
        {
            get
            {
                return antaltimmar;
            }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    antaltimmar = value;
                }
                else
                {
                    throw new ArgumentException("");
                }
            }
        }

        public Arbetare(string förnamn, string efternamn, string lön, string antaltimmar) : base(förnamn, efternamn)
        {
            try
            {
                if (!(int.TryParse(lön, out int resultatLön)))
                {
                    throw new ArgumentException("Lön måste vara ett heltal");
                }
                else
                {
                    Lön = resultatLön;
                }
                if (!(int.TryParse(antaltimmar, out int resultatTimmar)))
                {
                    throw new ArgumentException("Antaltimmar måste vara ett heltal");
                }
                else
                {
                    Antaltimmar = resultatTimmar;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        private float RäknaUtTimlön()
        {
            return lön / antaltimmar;
        }
    }
}