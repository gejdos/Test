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
        Otazka[] otazky = new Otazka[5];
        DatabazaOtazok db = new DatabazaOtazok();
        Random r = new Random();
        ArrayList nahodCisla = new ArrayList();

        public Test()
        {         
            VyberOtazky();
        }

        private void VyberOtazky()
        {

            for (int i = 0; i < otazky.Length; i++)
            {
                int index;
                
                do
                {
                    index = r.Next(5);

                } while (nahodCisla.Contains(index));
                
                nahodCisla.Add(index);
                
                //otazky[i].TypOtazky = TypOtazky.SingleChoice;
                otazky[i].ZnenieOtazky = db.Otazky[index];
                otazky[i].Moznosti = db.Moznosti[index];
                otazky[i].SpravnaOdpoved = db.SpravneOdpovede[index];
            }
            
            foreach (Otazka o in otazky)
            {
                Console.WriteLine(o.ZnenieOtazky);

                for (int i = 0; i < o.Moznosti.Length; i++)
                {
                    Console.WriteLine("{0}. {1}", (Odpoved)i, o.Moznosti[i]);
                }
               
            }

            foreach (int s in nahodCisla)
            {
                Console.WriteLine(s);
            }
        }

        private void PolozOtazku()
        {

        }

    }
}
