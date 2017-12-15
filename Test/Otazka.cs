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
        Dictionary<string, string> MultChoice = new Dictionary<string, string>();
        Tuple<string, string, string> moznosti = new Tuple<string, string, string>();

        enum TypOtazky
        {
            SingleChoice,
            MultipleChoice
        }

        public Otazka()
        {
            MultChoice.Add("Kolko je 5 + 5", { "10","15"});



        }
    
        
        
       
        
    }
}
