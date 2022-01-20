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

        public IDictionary<string, int> _bilar = new Dictionary<string, int>
        {
        {"ABC123",500},
        {"DEF456",400},
        {"GHI789",199}
        };
        public int RäknaKostnad()
        {
            //@todo inte krascha om regnr inte finns
            Kostnad = _bilar[RegNr] * Tidsram + Km * 2;
            return Kostnad;
        }
        public string Räknainlämningsdatum()
        {
            return Datum.AddDays(Tidsram).ToString("dd MMMM yyyy");
        }
        public bool finnsRegnr()
        {
            if (_bilar.ContainsKey(RegNr))
            {
                return true;
            }
            else
            {
                Console.WriteLine("Regnr finns inte");
                return false;
            }
        }
    }
}