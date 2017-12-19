using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DatabazaOtazok
    {        
        public string[] OtazkySC = new string[] 
        {
            "Kolko je 5 x 5",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?"
        };

        public string[][] MoznostiSC =
        {
            new string[] { "15", "10", "25" },
            new string[] { "slon", "velryba", "gorila" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Andrej Kiska" }

        };

        public OznacenieOdpovede[] SpravneOdpovedeSC = new OznacenieOdpovede[]
        {
            OznacenieOdpovede.C,
            OznacenieOdpovede.A,
            OznacenieOdpovede.C
        };

        public string[] OtazkyMC = new string[]
{
            "Oznac programovacie jazyky.",
            "",
            ""
};

        public string[][] MoznostiMC =
        {
            new string[] { "ABC", "C#", "C++" },
            new string[] { "slon", "velryba", "gorila" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Andrej Kiska" }

        };

        public OznacenieOdpovede[][] SpravneOdpovedeMC =
        {
            new OznacenieOdpovede[] { OznacenieOdpovede.B, OznacenieOdpovede.C },
           new OznacenieOdpovede[] { OznacenieOdpovede.A },
            new OznacenieOdpovede[] { OznacenieOdpovede.C }
        };
    }
}
