using System.Collections.Generic;
using System;
using RestSharp;
using System.Text.Json;

namespace Labb10
{
    class Starwars
    {
        public List<character> results { get; set; }
    }
    class character
    {
        public string name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hämta alla karaktärer");
            string url = "https://swapi.dev/api/";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);
            Starwars Results = new Starwars();
            Results = JsonSerializer.Deserialize<Starwars>(response.Content);
            if (Results != null)
            {
                foreach (var item in Results.results)
                {
                    System.Console.WriteLine(item.name);
                }
            }
        }
    }
}
