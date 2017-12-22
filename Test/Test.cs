using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Test
    {
        Otazka[] otazky = new Otazka[10];
        DatabazaOtazok db = new DatabazaOtazok();
        Random r = new Random();

        public Test()
        {         
            VyberOtazky();
        }

        private void VyberOtazky()
        {

            for (int i = 0; i < otazky.Length / 2; i++)
            {

                int index = r.Next(4);

                //otazky[i].TypOtazky = TypOtazky.SingleChoice;
                otazky[i].ZnenieOtazky = db.Otazky[index];
                otazky[i].Moznosti = db.Moznosti[index];
                otazky[i].SpravnaOdpoved = db.SpravneOdpovede[index];




            }
        }

    }
}
