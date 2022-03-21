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
        public Person(string a, string b)
        {
            Förnamn = a;
            Efternamn = b;
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
}