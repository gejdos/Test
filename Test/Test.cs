using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;

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
            Console.WriteLine("Cas na vyplnenie testu je 2 minuty.");
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
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 120000; //2 minuty
            timer.Elapsed += Timer_Elapsed; timer.Start();
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

                ZaradDoHistorie(otazky[i], odpoved);
            }

            timer.Stop();

            Vyhodnot();
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("CAS VYPRSAL.\nPROGRAM BUDE UKONCENY.");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        private bool SkontrolujVstup(string input)
        {
            Regex reg = new Regex(@"^(?!.*?(.).*?\1)[a-eA-E].*$");

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
            }
            else
            {
                for (int i = 0; i < odpovedUpperCase.Length; i++)
                {
                    if (Array.Exists(otazka.SpravnaOdpoved, element => element.ToString() == odpovedUpperCase[i].ToString()))
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

        private void ZaradDoHistorie(Otazka o, string odpoved)
        {
            historia.Enqueue("OTAZKA: " + o.ZnenieOtazky);
            historia.Enqueue("VASA ODPOVED:");
            for (int j = 0; j < odpoved.Length; j++)
            {
                Odpoved odp = (Odpoved)Enum.Parse(typeof(Odpoved), odpoved[j].ToString().ToUpper());

                historia.Enqueue("\t" + o.Moznosti[(int)odp]);
            }

            historia.Enqueue("SPRAVNA ODPOVED:");
            foreach (Odpoved odp in o.SpravnaOdpoved)
            {
                historia.Enqueue("\t" + o.Moznosti[(int)odp]);
            }
        }

        private void Vyhodnot()
        {
            Console.WriteLine("\n--------------------------------VYHODNOTENIE--------------------------------");

            if (body < 0)
            {
                body = 0;
            }

            if (body == 1)
            {
                Console.WriteLine("\nZISKALI STE 1 BOD.\n");
            }
            else if (body > 1 && body < 5)
            {
                Console.WriteLine("\nZISKALI STE {0} BODY.\n", body);
            }
            else
            {
                Console.WriteLine("\nZISKALI STE {0} BODOV.\n", body);
            }
            
            while (historia.Count > 0)
            {
                Console.WriteLine(historia.Dequeue());
            }
        }
    }
}
