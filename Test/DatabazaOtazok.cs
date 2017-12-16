using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DatabazaOtazok
    {
        public string[] SingleChoiceOtazky = new string[] 
        {
            "Kolko je 5 + 5",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?"
        };

        public string[][] SingleChoiceMoznosti =
        {
            new string[] { "15", "10", "20" },
            new string[] { "slon", "velryba", "gorila" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Andrej Kiska" }

        };

        public OznacenieOdpovede[] SpravneOdpovedeSC = new OznacenieOdpovede[]
        {
            OznacenieOdpovede.B,
            OznacenieOdpovede.A,
            OznacenieOdpovede.C            
        };

    }
}
