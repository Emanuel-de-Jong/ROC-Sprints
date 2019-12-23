using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_14
{
    class Program
    {
        //asks the user to input a decimal number and gives back its binary and hexadecimal value
        static void Main(string[] args)
        {
            string opnieuw;
            //do while loop for if the user wants to run the program again
            do
            {
                Console.WriteLine("Dit programma maakt van een ingevoerde decimaal een binaire en hexadecimaal nummer.");
                System.Threading.Thread.Sleep(1000);
                //lets the user assign a decimal number
                Console.WriteLine("Decimaal:");
                string decimaal = Console.ReadLine();
                //tests if the users input was a number
                if (int.TryParse(decimaal, out int resultaat))
                {
                    while (Convert.ToDouble(decimaal) < 1)
                    {
                        Console.WriteLine("Het nummer moet hoger zijn dan 0!");
                        decimaal = Console.ReadLine();
                    }
                }
                else
                {
                    while (!(int.TryParse(decimaal, out int resultaat2)))
                    {
                        Console.WriteLine("Het moet een nummer zijn!");
                        decimaal = Console.ReadLine();
                    }
                }

                //converts the decimal number to a binary number string
                string binair = Convert.ToString(Convert.ToInt32(decimaal), 2);
                Console.WriteLine("\nBinair:\n" + binair);

                //converts the decimal number to a hexadecimal number string
                string hexadecimaal = Convert.ToInt32(decimaal).ToString("X");
                Console.WriteLine("\nhexadecimaal:\n" + hexadecimaal);

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
