using System;
using System.Collections.Generic;

namespace Ny_mapp
{
    public class avtal
    {
        public DateTime Datum { get; set; }
        public string RegNr { get; set; }
        public int Km { get; set; }
        public int Kostnad { get; set; }
        public int Tidsram { get; set; }
        public string Personnr { get; set; }
        public IDictionary<string, int> Bilar { get => _bilar; set => _bilar = value; }

        private IDictionary<string, int> _bilar = new IDictionary<string, int>();

        _bilar.add("ABC123",500);
        _bilar.add("DEF456",400);
        _bilar.add("GHI789",199);
    }
}