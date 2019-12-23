using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_11
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            //defines the title of the console
            Console.Title = "Opdracht_6_11";


            //prints out the programs function
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(
                "************************************************************************************************************\n" +
                "*  Dit programma Laat u twee nummers invoeren en laat u alle mathematische functies met deze nummers zien  *\n" +
                "************************************************************************************************************\n" +
                "\n");


            //assigns the variables
            string opnieuw, x, y;
            double sum, difference1, difference2, product, quotient1, quotient2, remainder1, remainder2;


            //do while loop for if the user wants to run the program again
            do
            {
                //asks the user for
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Geef een nummer in.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                x = Console.ReadLine();
                while(x == "0" || !(Int32.TryParse(x, out int result1)))
                {
                    while (x == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet mag geen 0 zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        x = Console.ReadLine();
                    }
                    while (!(Int32.TryParse(x, out int result2)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet moet een nummer zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        x = Console.ReadLine();
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nGeef nog een nummer in.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                y = Console.ReadLine();
                while (y == "0" || !(Int32.TryParse(x, out int result3)))
                {
                    while (y == "0")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet mag geen 0 zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        y = Console.ReadLine();
                    }
                    while (!(Int32.TryParse(y, out int result4)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet moet een nummer zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        y = Console.ReadLine();
                    }
                }
                Console.WriteLine("");


                //calculates
                Calculate(Convert.ToDouble(x), Convert.ToDouble(y), out sum, out difference1, out difference2, out product, out quotient1, out quotient2, out remainder1, out remainder2);


                //prints out
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(
                x + " + " + y + " = {0}\n" +
                x + " - " + y + " = {1}\n" +
                y + " - " + x + " = {2}\n" +
                x + " * " + y + " = {3}\n" +
                x + " / " + y + " = {4}\n" +
                y + " / " + x + " = {5}\n" +
                x + " % " + y + " = {6}\n" +
                y + " % " + x + " = {7}",
                sum, difference1, difference2, product, quotient1, quotient2, remainder1, remainder2
                );


                //asks if the user wants to run the program again
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWilt u het opnieuw proberen? (ja/nee)");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                opnieuw = Console.ReadLine();


                //tries if the users input contains "ja" (dutch for yes) or "nee" (dutch for no)
                while (!(opnieuw.ToLower().Contains("ja") || opnieuw.ToLower().Contains("nee")))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOngeldig. Geef \'ja\' of \'nee\' in.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    opnieuw = Console.ReadLine();
                }
                Console.Clear();
            } while (opnieuw.ToLower().Contains("ja"));
        }
        public static void Calculate(double x, double y, out double sum, out double difference1, out double difference2, out double product, out double quotient1, out double quotient2, out double remainder1, out double remainder2)
        {
            sum = x + y;
            difference1 = x - y;
            difference2 = y - x;
            product = x * y;
            quotient1 = x / y;
            quotient2 = y / x;
            remainder1 = x % y;
            remainder2 = y % x;

        }
    }
}
