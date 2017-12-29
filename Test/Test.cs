using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Test
{
    partial class Test
    {
        const int pocetOtazok = 5;
        Otazka[] otazky = new Otazka[pocetOtazok];
        Random r = new Random();
        ArrayList nahodCisla = new ArrayList();
        int body;
        Queue historia = new Queue();

        public Test()
        {
            body = 0;
            VyberOtazky();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Toto je jednoduchy test zlozeny z {0} otazok.", pocetOtazok);
            Console.WriteLine("Priklad odpovede na Single Choice otazku: a / A");
            Console.WriteLine("Priklad odpovede na Multiple Choice otazku: abc / ABC");
            Console.WriteLine("------------------------------------------------------\n");
        }

        private void VyberOtazky()
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

        }

        public void PolozOtazky()
        {
            string odpoved;
            
            for (int i = 0; i < otazky.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + otazky[i].ZnenieOtazky);

                for (int j = 0; j < otazky[i].Moznosti.Length; j++)
                {
                    Console.WriteLine("\t{0}. {1}", (Odpoved)j, otazky[i].Moznosti[j]);
                }
                
                do
                {
                    odpoved = Console.ReadLine();

                } while (!SkontrolujVstup(odpoved));

                Oboduj(otazky[i], odpoved);


                //zarad do fronty
                historia.Enqueue("OTAZKA: " + otazky[i].ZnenieOtazky);
                historia.Enqueue("VASA ODPOVED:");
                for (int j = 0; j < odpoved.Length; j++)
                {
                    Odpoved odp = odpoved[j].ToString();

                    historia.Enqueue(otazky[i].Moznosti[(int)odp]);
                }

                historia.Enqueue("SPRAVNA ODPOVED:");
                foreach (Odpoved odp in otazky[i].SpravnaOdpoved)
                {
                    historia.Enqueue(odp);   
                }

                
            }
            
            Vyhodnot();
        }

        private bool SkontrolujVstup(string input)
        {
            Regex reg = new Regex(@"^(?!.*?(.).*?\1)[a-eA-E]*$");

            if (reg.IsMatch(input)) return true;
            
            Console.WriteLine("Nespravny vstup. Skuste to znovu.");
            return false;
        }

        private void Oboduj(Otazka otazka, string odpoved)
        {
            string odpovedUpperCase = odpoved.ToUpper();

            if (otazka.TypOtazky == TypOtazky.SingleChoice && odpovedUpperCase.Length > 1)
            {
                body--;
                Console.WriteLine("zle");
            }
            else
            {
                for (int i = 0; i < odpovedUpperCase.Length; i++)
                {
                    if (Array.Exists(otazka.SpravnaOdpoved, element => element.ToString() == odpovedUpperCase[i].ToString()))
                    {
                        body++;
                        Console.WriteLine("dobre");
                    }
                    else
                    {
                        body--;
                        Console.WriteLine("zle");
                    }
                }
            }
        }
     
        private void Vyhodnot()
        {
            if (body < 0)
            {
                body = 0;
            }

            Console.WriteLine("\nZiskali ste {0} bodov.\n", body);
            while (historia.Count > 0)
            {
                Console.WriteLine(historia.Dequeue());
            }
        }
    }
}
