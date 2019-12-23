using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_1
{
    //this program lets the user input a number representing a week day and outputs the name of that day
    class Program
    {
        static void Main(string[] args)
        {
            //assigns an array with the names of the days
            var dagen = new string[] { "maandag", "dinsdag", "woensdag", "donderdag", "vrijdag", "zaterdag", "zondag" };

            //outputs the purpose of the program
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dit programma laat u het nummer van een dag invoeren en geeft u de naam van die dag terug.\n");
            Console.ResetColor();

            //tests if the output is valid until it is
            Console.WriteLine("Uw nummer:");
            int dag = 0;
            while (true)
            {
                try
                {
                    dag = Convert.ToInt32(Console.ReadLine());
                    //tests the range
                    if (dag < 1 || dag > 7)
                    {
                        Console.WriteLine("Het nummer is niet tussen 1 en 7!");
                    }
                    else
                    {
                        break;
                    }
                }
                //tests the convert
                catch (FormatException)
                {
                    Console.WriteLine("De ingave is geen nummer!");
                }
                //outputs any other errors
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            //outputs the day
            Console.WriteLine(dagen[dag - 1]);

            Console.ReadLine();
        }
    }
}