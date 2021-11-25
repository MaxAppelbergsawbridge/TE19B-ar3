using System;
using RestSharp;
using System.Text.Json;
namespace ChuckNorrisAPI
{
    class Joke
    {
        public string icon_url { get; set; }
        public string value { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuck Norris skämt");
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);
            Joke skämtet = new Joke();
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);
            System.Console.WriteLine(skämtet.value);
        }
    }
}
