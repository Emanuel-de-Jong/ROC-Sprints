using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    //this program lets the user input a number between 2 and 150 and adds a rand number between 1 and 6 untill its the exact input number
    class Program
    {
        static void Main(string[] args)
        {
            //outputs the purpose of the program
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Dit programma laat u een nummer tussen 2 en 150 invoeren en gooit een dobbelsteen totdat het totaal dit exacte nummer is.\n");
            Console.ResetColor();

            //tests if the output is valid until it is
            int goal;
            Console.WriteLine("Geef het gewenst aantal ogen:");
            while (true)
            {
                try
                {
                    goal = Convert.ToInt32(Console.ReadLine());
                    //tests the range
                    if (goal < 2 || goal > 150)
                    {
                        Console.WriteLine("Het nummer is niet tussen 2 en 150!");
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

            var rnd = new Random();
            //the total and the last total of the random numbers
            int lastTotal;
            int total = 0;
            //counts the times 'thrown'
            int timesThrown = 0;
            while (total < goal)
            {
                timesThrown++;

                lastTotal = total;
                total += rnd.Next(1, 7);
                //if the input is overshot it will revert back to the last total number
                if (total > goal)
                {
                    total = lastTotal;
                }
            }

            //outputs the times thrown
            Console.WriteLine("Er is {0} keer gegooid om aantal {1} te behalen", timesThrown, total);

            Console.ReadLine();
        }
    }
}
