using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StromzählerApp
{
    internal class Unterzaehler
    {
        public string UnterzaehlerId { get; set; }
        public double VorherigerZaehlerstand { get; set; }
        public double AktuellerZaehlerstand { get; set; }
        public double Verbrauch { get; set; }
        public double PreisProKwh { get; set; }

    }
}
