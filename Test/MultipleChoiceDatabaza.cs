using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MultipleChoiceDatabaza
    {
        public string[] Otazky = new string[]
{
            "Oznac programovacie jazyky.",
            "",
            ""
};

        public string[][] Moznosti =
        {
            new string[] { "ABC", "C#", "C++" },
            new string[] { "", "", "" },
            new string[] { "", "", "" }

        };

        public OznacenieOdpovede[][] SpravneOdpovede =
        {
            new OznacenieOdpovede[] { OznacenieOdpovede.B, OznacenieOdpovede.C },
           new OznacenieOdpovede[] { OznacenieOdpovede.A },
            new OznacenieOdpovede[] { OznacenieOdpovede.C }
        };
    }
}
