using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    //this program lets the user input a number representing a month and outputs its quarter
    class Program
    {
        static void Main(string[] args)
        {
            //outputs the purpose of the program
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dit programma laat u het nummer van een maand invoeren en geeft u het kwartaal waarin deze valt terug.\n");
            Console.ResetColor();

            //tests input of the user
            Console.WriteLine("Geef het nummer van een maand in:");
            int month;
            while (true)
            {
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    //tests the range
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("Het nummer is niet tussen 1 en 12!");
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

            //outputs the quarter of the input month
            Console.WriteLine("\nHet kwartaal van de ingevude maand is:");
            if (month >= 1 && month <= 3)
            {
                Console.WriteLine("Kwartaal 1");
            }
            else if (month >= 4 && month <= 6)
            {
                Console.WriteLine("Kwartaal 2");
            }
            else if (month >= 7 && month <= 9)
            {
                Console.WriteLine("Kwartaal 3");
            }
            else
            {
                Console.WriteLine("Kwartaal 4");
            }

            Console.WriteLine("\nDruk op Enter om af te sluiten...");
            Console.ReadLine();
        }
    }
}
