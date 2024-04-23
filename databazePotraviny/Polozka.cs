using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databazePotraviny
{
    public class Polozka
    {
        public Polozka(int? iD, string nazev, string cena, int pocet)
        {
            ID = iD;
            Nazev = nazev;
            Cena = cena;
            this.pocet = pocet;
        }

        public int? ID { get; set; }
        public string Nazev { get; set; }
        public string Cena { get; set; }
        public int pocet {  get; set; }
    }
}
