using System.Collections.Generic;
using System;
using RestSharp;
using System.Text.Json;
namespace Hämta_pokemoninfo

{
    class Program
    {
        class Pokemon
        {
            public string name { get; set; }
        }
        class Pokemons
        {
            public int count { get; set; }
            public List<Pokemon> results { get; set; }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hämta alla pokemon!");
            string url = " https://pokeapi.co/api/v2/";
            var client = new RestClient(url);
            var request = new RestRequest("pokemon", DataFormat.Json);
            var response = client.Get(request);
            //kolla på svaret
            //System.Console.WriteLine(response.Content);
            Pokemons Lista = new Pokemons();
            Lista = JsonSerializer.Deserialize<Pokemons>(response.Content);
            if (Lista != null)
            {
                foreach (var item in Lista.results)
                {
                    System.Console.WriteLine(item.name);
                }
            }
        }
    }
}
