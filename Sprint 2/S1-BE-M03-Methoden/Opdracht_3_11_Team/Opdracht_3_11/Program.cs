using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //<Syon>
            DateTime now = DateTime.Now;
            Console.WriteLine("Jaar: {0}", now.Year);
            //</syon>

            //<Vincent>
            Console.WriteLine("Maand: " + now.ToString("MMMM", new System.Globalization.CultureInfo("nl-NL")));
            //</Vincent>

            //<Rico>
            Console.WriteLine("Dag (Woord): " + now.ToString("dddd", new System.Globalization.CultureInfo("nl-NL")));
            //</Ridco>

            //<Job>
            Console.WriteLine("Dag: " + now.Day);
            //</Job>

            //<Erel>
            double week = (now.DayOfYear);
            week = week / 7;
            int week2 = (now.DayOfYear);
            week2 = week2 / 7;
            if (week2 < week)
            {
                week2 = week2 + 1;
                Console.WriteLine("Week Numer: {0}", week2);

            }
            else
            {
                Console.WriteLine("Week Numer: {0}", week2);
            }
            //</Erel>

            //<Emanuel>
            Console.WriteLine("Dag in het jaar: " + now.DayOfYear);
            //</Emanuel>

            Console.ReadKey();
        }
    }
}
