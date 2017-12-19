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
        SingleChoiceDatabaza SCdb = new SingleChoiceDatabaza();
        MultipleChoiceDatabaza MCdb = new MultipleChoiceDatabaza();
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
                otazky[i].SpravnaOdpoved = SCdb.SpravneOdpovede[index];



            }
        }

    }
}
