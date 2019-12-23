using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string opnieuw = "ja";
            //while loop for if the user wants to run the program again
            while (opnieuw.ToLower().Contains("ja"))
            {
                //asks for number of month
                Console.WriteLine("Geef het nummer van een maand in (1-12). En het programma vertelt u welke maand het is en hoeveel dagen er in die maand zitten.");
                string maand = Console.ReadLine();
                //checks if the month is valid
                if (int.TryParse(maand, out int result))
                {
                    if (result > 0 && result < 13)
                    {
                        //shows some fancy info about the month that has been input
                        DateTime dtMaand = new DateTime(01, Convert.ToInt32(maand), 0001);
                        int dagenInMaand = DateTime.DaysInMonth(0001, Convert.ToInt32(maand));
                        //if the month is febuary, says it contains eighter 28 or 29 days (leap day)
                        if (Convert.ToInt32(maand) != 2)
                        {
                            Console.WriteLine("De gekozen maand is " + dtMaand.ToString("MMMM", new System.Globalization.CultureInfo("nl-NL")) + " en deze heeft " + dagenInMaand + " dagen.");
                        }
                        else
                        {
                            Console.WriteLine("De gekozen maand is " + dtMaand.ToString("MMMM", new System.Globalization.CultureInfo("nl-NL")) + " en deze heeft " + dagenInMaand + " dagen. In een schrikkeljaar is het aantal dagen in " + dtMaand.ToString("MMMM", new System.Globalization.CultureInfo("nl-NL")) + " 29.");
                        }
                    }
                    //month input wasn't between 1-12
                    else
                    {
                        Console.WriteLine("Het nummer moet tussen 1 en 12 zijn!");
                    }

                }
                //month input wasn't a number
                else
                {
                    Console.WriteLine("Het moet een nummer zijn!");
                }
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
