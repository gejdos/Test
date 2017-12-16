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
        public Hashtable tabulka = new Hashtable();
        
        public string[] Otazky = new string[] 
        {
            "Kolko je 5 x 5",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?",
            ""
        };

        public string[][] Moznosti =
        {
            new string[] { "15", "10", "25" },
            new string[] { "slon", "velryba", "gorila" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Andrej Kiska" }

        };

        public OznacenieOdpovede[][] SpravneOdpovede =
        {
            new OznacenieOdpovede[] { OznacenieOdpovede.C },
            new OznacenieOdpovede[] { OznacenieOdpovede.A },
            new OznacenieOdpovede[] { OznacenieOdpovede.C }
        };
    }
}
