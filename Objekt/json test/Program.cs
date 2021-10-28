using System;
using Newtonsoft.Json;
using System.IO;
namespace json_test
{
    class Film
    {
        public string Titel;
        public string Årtal;
        public string Regissör;
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("skapa en JSON-objekt");
            //Objektet avatar
            Film avatar = new Film()
            {
                Titel = "Avatar",
                Årtal = "2009",
                Regissör = "James Cameron"
            };
            Film legend = new Film()
            {
                Titel = "I am legend",
                Årtal = "2008",
                Regissör = "Francis Lawrence"
            };
            Film interstellar = new Film()
            {
                Titel = "Interstellar",
                Årtal = "2014",
                Regissör = "Christopher Nolan"
            };
            string jsonText = JsonConvert.SerializeObject(avatar, Formatting.Indented);
            jsonText += ", \n" + JsonConvert.SerializeObject(avatar, Formatting.Indented);
            System.Console.WriteLine(jsonText);
            File.WriteAllText("filmer.json", jsonText);
        }
    }
}
