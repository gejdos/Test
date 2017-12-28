using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    partial class Test
    {
        const int pocetOtazok = 5;
        Otazka[] otazky = new Otazka[pocetOtazok];
        Random r = new Random();
        ArrayList nahodCisla = new ArrayList();
        Otazka[] vybrateOtazky;
        int body;

        public Test()
        {
            vybrateOtazky = VyberOtazky();
        }

        private Otazka[] VyberOtazky()
        {
            for (int i = 0; i < pocetOtazok; i++)
            {
                int index;

                do
                {
                    index = r.Next(10);

                } while (nahodCisla.Contains(index));

                nahodCisla.Add(index);

                otazky[i].ZnenieOtazky = Otazky[index];
                otazky[i].Moznosti = Moznosti[index];
                otazky[i].SpravnaOdpoved = SpravneOdpovede[index];

                if (otazky[i].SpravnaOdpoved.Length == 1)
                {
                    otazky[i].TypOtazky = TypOtazky.SingleChoice;
                }
                else
                {
                    otazky[i].TypOtazky = TypOtazky.MultipleChoice;
                }
            }

            return otazky;
        }

        public void PolozOtazky()
        {
            string odpoved;
            
            for (int i = 0; i < vybrateOtazky.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + vybrateOtazky[i].ZnenieOtazky);

                for (int j = 0; j < vybrateOtazky[i].Moznosti.Length; j++)
                {
                    Console.WriteLine("\t{0}. {1}", (Odpoved)j, vybrateOtazky[i].Moznosti[j]);
                }
                
                do
                {
                    odpoved = Console.ReadLine();

                } while (!SkontrolujVstup(odpoved));

                Vyhodnot(otazky[i], odpoved);
            }
        }

        private bool SkontrolujVstup(string input)
        {
            Regex reg = new Regex(@"^(?!.*?(.).*?\1)[a-eA-E]*$");

            if (reg.IsMatch(input)) return true;
            
            Console.WriteLine("Nespravny vstup. Skuste to znovu.");
            return false;
        }

        private void Vyhodnot(Otazka otazka, string odpoved)
        {

            if (otazka.TypOtazky == TypOtazky.SingleChoice)
            {
                if (odpoved.Length > 1 || odpoved != otazka.SpravnaOdpoved[0].ToString())
                {
                    body--;
                }
                else
                {
                    body++;
                }
            }
            else
            {
                if (odpoved.Length == 1)
                {
                    body--;
                }
                else
                {
                    for (int i = 0; i < odpoved.Length; i++)
                    {
                        for (int j = 0; j < otazka.SpravnaOdpoved.Length; j++)
                        {
                            if (odpoved[i].ToString() == otazka.SpravnaOdpoved[j].ToString())
                            {
                                body++;
                            }
                            else
                            {
                                body--;
                            }
                        }

                    }
                }
            }
        }
    }
}
