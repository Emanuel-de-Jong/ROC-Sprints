using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_13
{
    class Program
    {
        static void Main(string[] args)
        {

            string opnieuw = "ja";
            //while loop for if the user wants to run the program again
            while (opnieuw.ToLower().Contains("ja"))
            {
                //assigns variables
                int numer, numerKwadraat, laasteNumerKwadraat;

                //asks for input
                Console.WriteLine("Geef een getal in.");
                numer = Convert.ToInt16(Console.ReadLine());

                //calculates
                numerKwadraat = numer * numer;
                laasteNumerKwadraat = numerKwadraat % 10;
                if (laasteNumerKwadraat == numer)
                {
                    Console.WriteLine(numer + " is een automorf");
                }
                else
                {
                    Console.WriteLine(numer + " is geen automorf");
                }

                //gives output
                Console.WriteLine("Een automorf is een getal waarvan het kwadraat eindigt op dezelfde cijfers als het getal zelf.");
                Console.ReadLine();
                //asks if the user wan't to run the program again
                Console.WriteLine("Wilt u opnieuw het proberen? (ja/nee)");
                opnieuw = Console.ReadLine();
                //tests if the users input was valid (yes/no)
                while (!(opnieuw.ToLower().Contains("ja") || opnieuw.ToLower().Contains("nee")))
                {
                    Console.WriteLine(@"Ongeldig. Geef ""ja"" of ""nee"" in.");
                    opnieuw = Console.ReadLine();

                }
            }
        }
    }
}
