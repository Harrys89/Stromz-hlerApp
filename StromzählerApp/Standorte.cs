using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StromzählerApp
{
    internal class Standorte
    {
        public string Stadt { get; set; }
        public string Plz { get; set; }
        public string Ort { get; set; }
        public string Gebaeude { get; set; }
        public string Straße { get; set; }
        public string Hausnummer { get; set; }
        public string Etage { get; set; }
        public string Raum { get; set; }
        public Standorte(string stadt, string plz, string ort, string gebaeude, string straße, string hausnummer, int etage, string raum, string unterzaehlerId)
        {
            Stadt = stadt;
            Plz = plz;
            Ort = ort;
            Gebaeude = gebaeude;
            Straße = straße;
            Hausnummer = hausnummer;
            Etage = etage.ToString();
            Raum = raum;
        }
    }
}
