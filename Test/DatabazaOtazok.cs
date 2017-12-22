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
            "Kolko je 5 x 5?",
            "Aky je najvacsi suchozemsky cicavec?",
            "Ako sa vola sucasny slovensky prezident?",
            "Ktore z uvedenych moznosti patria medzi programovacie jazyky?",
            "Ktore z uvedenych miest sa nachadzaju na Slovensku?"

        };

        public string[][] Moznosti =
        {
            new string[] { "15", "10", "25", "18", "20" },
            new string[] { "slon", "velryba", "gorila", "zirafa", "nosorozec" },
            new string[] { "Ivan Gasparovic", "Robert Fico", "Pavol Rusko", "Andrej Kiska", "Vlaclav Klaus" },
            new string[] { "C++", "ABC", "C#", "RDR", "ACCA" },
            new string[] { "Brno", "Chorvatsky Grob", "Zvolen", "Kromeriz", "Skalica" }

        };

        public Odpoved[][] SpravneOdpovede = 
        {
            new Odpoved[] { Odpoved.C },
            new Odpoved[] { Odpoved.A },
            new Odpoved[] { Odpoved.D },
            new Odpoved[] { Odpoved.A, Odpoved.C },
            new Odpoved[] { Odpoved.B, Odpoved.C, Odpoved.E }
        };
    }
}
