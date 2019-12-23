using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_10
{
    class Program
    {
        //calculates the time it took to input the users name and age
        static void Main(string[] args)
        {
            //assigns variables
            DateTime tijdVoor = DateTime.Now;

            //asks for input
            Console.WriteLine("Wat is uw naam?");
            Console.ReadLine();
            Console.WriteLine("Wat is uw leeftijd?");
            Console.ReadLine();

            //calculates time between input
            DateTime tijdNa = DateTime.Now;
            double VerschilTijd = (tijdNa - tijdVoor).TotalSeconds;
            Console.WriteLine("Het heeft " + VerschilTijd + " seconden gekost om uw naam en leeftijd in te geven.");
            Console.ReadLine();
        }
    }
}
