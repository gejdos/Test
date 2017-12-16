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

            NaplnSingleChoiceOtazky();
            //NaplnMultipleChoiceOtazky();
        }

        private void NaplnSingleChoiceOtazky()
        {

            for (int i = 0; i < otazky.Length / 2; i++)
            {

                int index = r.Next(3);

                otazky[i].TypOtazky = TypOtazky.SingleChoice;
                otazky[i].SpravnaOdpoved = db.SpravneOdpovedeSC[index];
                //otazky[i].OtazkaAMoznosti.Add(db.SingleChoiceOtazky[index], db.SingleChoiceMoznosti[index]);
                
                Console.WriteLine(index + " " + otazky[i].SpravnaOdpoved);

            }
        }

    }
}
