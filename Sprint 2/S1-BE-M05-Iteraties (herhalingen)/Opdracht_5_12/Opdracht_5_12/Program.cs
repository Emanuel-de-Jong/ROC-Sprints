using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_12
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
                List<int> tenNumbs = new List<int>();
                string number;

                //asks 10 numbers
                Console.WriteLine("Geef 10 getallen in. Het programma laat zien welke getallen het hoogst (blauw) en welke het kleinst (rood) zijn.");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("\n" + i + ":");
                    number = Console.ReadLine();
                    //checks if the input is the right datatype
                    if (int.TryParse(number, out int result))
                    {
                        tenNumbs.Add(Convert.ToInt32(number));
                    }
                    else
                    {
                        Console.WriteLine("Het moet een nummer zijn!");
                        i--;
                    }
                }

                //calculates
                int max = tenNumbs.Max();
                int min = tenNumbs.Min();
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------");
                Console.WriteLine();

                //shows the result
                for (int i = 0; i < 10; i++)
                {
                    if (tenNumbs[i] == max)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(max);
                        Console.ResetColor();
                    }
                    else if(tenNumbs[i] == min)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(min);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine(tenNumbs[i]);
                    }
                }

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
