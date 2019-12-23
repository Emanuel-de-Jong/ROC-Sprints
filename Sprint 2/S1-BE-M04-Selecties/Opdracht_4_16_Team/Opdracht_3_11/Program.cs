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

            //----------------------------------------------

            //<Job>
            int schrikkeljaar = now.Year;
            //</Job>

            //<erel>
            if (schrikkeljaar % 4 == 0 && schrikkeljaar % 100 == 0 && schrikkeljaar % 400 == 0)
            {
                Console.WriteLine("het jaar is geen schrikkeljaar");
            }
            else
            {
                Console.WriteLine("het jaar is een schrikkeljaar");
            }
            //</erel>

            //<vincent>
            DayOfWeek dag = now.DayOfWeek;
            //</vincent>

            //<Syon>
            int werkdag = Convert.ToInt32(dag);
            //</Syon>

            //<Emanuel>
            if (werkdag > 0 && werkdag < 5)
            {
                Console.WriteLine("het is een werkdag");
            }
            //</Emanuel>

            //<Rico>
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("het is weekend");
            }
            Console.ReadKey();
            //</Rico>
        }
    }
}
