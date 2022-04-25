using System;

namespace slutprojet_oop
{
    public class Objekt
    {
        //namnet på objektet
        public string Namn { get; set; }
        //mängd av objekt
        public string Mängd { get; set; }
        //när användaren skaffade objektet
        public string Datum { get; set; }
        //länk
        public string Info { get; set; }
        public Objekt(string namn, string mängd, string datum, string info)
        {
            Namn = namn;
            Mängd = mängd;
            Datum = datum;
            Info = info;
        }
    }
}