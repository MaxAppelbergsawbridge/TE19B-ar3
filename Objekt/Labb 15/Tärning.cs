using System;

namespace Labb_15
{
    public class Tärning
    {
        public int Tärningssidor { get; set; }
        public Tärning()
        {
            var rand = new Random();
            int _tärningssidor = rand.Next(20);
            Tärningssidor = _tärningssidor;
        }
    }
}
