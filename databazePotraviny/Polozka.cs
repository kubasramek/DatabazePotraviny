using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace databazePotraviny
{
    public class Polozka
    {
        public Polozka(int? iD, string nazev, int cena, int pocet)
        {
            ID = iD;
            Nazev = nazev;
            Cena = cena;
            Pocet = pocet;
        }

        public int? ID { get; set; }
        public string Nazev { get; set; }
        public int? Cena { get; set; }
        public int? Pocet {  get; set; }


        public override string ToString() // metoda která vypíše jednotlivé parametry 
        {
            return $"{Nazev} {Cena}Kč/Kg {Pocet}Ks";
        }
    }
}
