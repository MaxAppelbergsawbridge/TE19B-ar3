using System;
using System.Collections.Generic;
namespace construktor
{
    public class bok
    {
        public string titel { get; set; }
        public string författare { get; set; }
        public int antalSidor { get; set; }
        bok papper = new bok();
        List<bok> listaBok = new List<bok>();
        public void SkrivUt()
        {
            Console.WriteLine(papper.titel + papper.författare + papper.antalSidor);
        }
    }
}