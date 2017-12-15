using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Otazka
    {
        enum TypOtazky
        {
            SingleChoice,
            MultipleChoice
        }

        readonly Hashtable otazky = new Hashtable { "Kolko je 5 + 5":"10" }
    }
}
