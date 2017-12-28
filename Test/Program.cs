using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test novyTest = new Test();
            //novyTest.PolozOtazky();
            while (true)
            {
                Regex reg = new Regex(@"^(?!.*?(.).*?\1)[a-eA-E]*$");
                Console.WriteLine((reg.IsMatch(Console.ReadLine())));
            }

            //Console.WriteLine((int)Odpoved.A);

            //Console.ReadKey();
        }
    }
}
