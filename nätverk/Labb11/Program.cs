using System;

namespace Labb11
{
    class Nasa
    {
        public list<bild> dagensbild { get; set; }
    }
    class bild
    {
        public string url { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta Nasas!");
            string url = "https://api.nasa.gov/planetary/apod";
            var client = new RestClient(url);
            var request = new RestRequest("api_key", DataFormat.Json);
            var response = client.Get(request);

        }
    }
}
