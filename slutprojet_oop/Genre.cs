using System;
using System.Collections.Generic;

namespace slutprojet_oop
{
    public class Genre : Objekt
    {
        public string GenreNamn { get; set; }
        public string MängdObjekt { get; set; }
        //användare anger egenskaper som klassen ärver?
        public string DatumGenre { get; set; }
        //länk
        public string InfoGenre { get; set; }
        public string ListAvEgenskaper { get; set; }
        public Genre(string genreNamn, string mängdObjekt, string listAvEgenskaper, string datum, string info) : base(genreNamn, mängdObjekt, datum, info)
        {
            GenreNamn = genreNamn;
            MängdObjekt = mängdObjekt;
            InfoGenre = info;
            DatumGenre = datum;
            ListAvEgenskaper = listAvEgenskaper;
        }
    }


}