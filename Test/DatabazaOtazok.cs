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
        public string[] Otazky = new string[] 
        {
            "Kolko je 5 x 5",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?",
            "Ktore z uvedenych moznosti su programovacie jazyky?"
        };

        public string[][] Moznosti =
        {
            new string[] { "15", "10", "25" },
            new string[] { "slon", "velryba", "gorila" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Andrej Kiska" },
            new string[] { "C++", "ABC", "C#" }

        };

        public OznacenieOdpovede[][] SpravneOdpovede = 
        {
            new OznacenieOdpovede[] { OznacenieOdpovede.B },
            new OznacenieOdpovede[] { OznacenieOdpovede.A },
            new OznacenieOdpovede[] { OznacenieOdpovede.C },
            new OznacenieOdpovede[] { OznacenieOdpovede.A, OznacenieOdpovede.C }
        };
    }
}
