using System;
using System.Collections.Generic;

namespace slutprojet_oop
{
    public class Genre
    {
        public string GenreNamn { get; set; }
        public string MängdObjekt { get; set; }
        //användare anger egenskaper som klassen ärver?
        public List<Egenskaper> ListAvEgenskaper { get; set; }
        public Genre(string genreNamn, string mängdObjekt, List<Egenskaper> listAvEgenskaper)
        {
            GenreNamn = genreNamn;
            MängdObjekt = mängdObjekt;
            ListAvEgenskaper = listAvEgenskaper;
        }
    }

    public class Egenskaper
    {
        public string EgenskaperNamn { get; set; }
    }
}