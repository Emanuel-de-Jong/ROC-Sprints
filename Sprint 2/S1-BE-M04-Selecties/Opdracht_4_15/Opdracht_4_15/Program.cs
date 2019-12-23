using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string opnieuw;
            //do while loop for if the user wants to run the program again
            do
            {
                //assigns variables
                Int32 wk, sk, nk, totaal;

                Console.WriteLine("Dit programma rekend uit of u aan het exame deel mag nemen.");
                //asks for input
                Console.WriteLine("Wat is uw score voor wiskunde?");
                Int32.TryParse(Console.ReadLine(), out wk);
                Console.WriteLine("Wat is uw score voor scheikunde?");
                Int32.TryParse(Console.ReadLine(), out sk);
                Console.WriteLine("Wat is uw score voor natuurkunde?");
                Int32.TryParse(Console.ReadLine(), out nk);

                //calculates wether the user may participate in the exames or not
                totaal = wk + sk + nk;
                if ((wk >= 60 && (sk >= 60 || nk >= 60) || totaal >= 180) && (!(wk < 40) && !(sk < 40) && !(nk < 40)))
                {
                    Console.WriteLine("U bent toegelaten voor het exame!");
                }
                else
                {
                    Console.WriteLine("U bent helaas niet toegelaten voor het exame.");
                }
                Console.ReadLine();

                //asks if the user wants to run the program again
                Console.WriteLine("\nWilt u het opnieuw proberen? (ja/nee)");
                opnieuw = Console.ReadLine();
                //tests if the users input contains "ja" (dutch for yes) or "nee" (dutch for no)
                while (!(opnieuw.ToLower().Contains("ja") || opnieuw.ToLower().Contains("nee")))
                {
                    Console.WriteLine(@"Ongeldig. Geef ""ja"" of ""nee"" in.");
                    opnieuw = Console.ReadLine();
                }
                Console.WriteLine("\n");
            } while (opnieuw.ToLower().Contains("ja"));
        }
    }
}
