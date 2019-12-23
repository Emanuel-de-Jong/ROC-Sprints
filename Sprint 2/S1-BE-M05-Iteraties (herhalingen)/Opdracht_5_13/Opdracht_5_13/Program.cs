using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string opnieuw;
            //do while loop for if the user wants to run the program again
            do
            {
                //asigns variables
                string text;
                int klinkers, medeKlinkers, cijfers, andereTekens;
                var hsKlinkers = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
                var hsMedeKlinkers = new HashSet<char> { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
                var hsCijfers = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                //asks for input
                Console.WriteLine("Geef in wat u ook maar wilt en dit programma zal u de hoeveelheid klinkers, medeklinkers, cijfers en andere tekens vetellen");
                text = Console.ReadLine().ToLower();

                //calculates
                klinkers = text.Count(c => hsKlinkers.Contains(c));
                medeKlinkers = text.Count(c => hsMedeKlinkers.Contains(c));
                cijfers = text.Count(c => hsCijfers.Contains(c));
                andereTekens = text.Length - (klinkers + medeKlinkers + cijfers);

                //shows the result
                Console.WriteLine("Uw text heeft {0} klinkers, {1} medeklinkers, {2} cijfers en {3} andere tekens.", klinkers, medeKlinkers, cijfers, andereTekens);

                //asks if the user wants to run the program again
                Console.WriteLine("Wilt u het opnieuw proberen? (ja/nee)");
                opnieuw = Console.ReadLine();
                //tests if the users input was valid (yes/no)
                while (!(opnieuw.ToLower().Contains("ja") || opnieuw.ToLower().Contains("nee")))
                {
                    Console.WriteLine(@"Ongeldig. Geef ""ja"" of ""nee"" in.");
                    opnieuw = Console.ReadLine();
                }
            } while (opnieuw.ToLower().Contains("ja"));
        }
    }
}
