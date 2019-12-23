using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opnieuw;
            //do while loop for if the user wants to run the program again
            do
            {
                DateTime dtDate;
            string strDate;
            Console.WriteLine("Geef een datum in. Dit programma zal u uw sterrenbeeld laten zien.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                strDate = Console.ReadLine();
                while (!(DateTime.TryParse(strDate, out DateTime result)))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet moet een datum zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        strDate = Console.ReadLine();
                    }
            dtDate = Convert.ToDateTime(strDate);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nJe sterrenbeeld is: "+Zodiac(dtDate));

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
        enum sterrenbeeld
        {
            steenbok,
            waterman,
            vissen,
            ram,
            stier,
            tweeling,
            kreeft,
            leeuw,
            maagd,
            weegschaal,
            schorpioen,
            boogschutter
        }
        public static string Zodiac(DateTime datum)
        {
            sterrenbeeld sbSterrenbeeld;
            if ((datum.Month == 12 && datum.Day >= 22) || (datum.Month == 1 && datum.Day <= 20))
            {
                sbSterrenbeeld = sterrenbeeld.steenbok;
            }
            else if ((datum.Month == 1 && datum.Day >= 21) || (datum.Month == 2 && datum.Day <= 19))
            {
                sbSterrenbeeld = sterrenbeeld.waterman;
            }
            else if ((datum.Month == 2 && datum.Day >= 20) || (datum.Month == 3 && datum.Day <= 20))
            {
                sbSterrenbeeld = sterrenbeeld.vissen;
            }
            else if ((datum.Month == 3 && datum.Day >= 21) || (datum.Month == 4 && datum.Day <= 20))
            {
                sbSterrenbeeld = sterrenbeeld.ram;
            }
            else if ((datum.Month == 4 && datum.Day >= 21) || (datum.Month == 5 && datum.Day <= 20))
            {
                sbSterrenbeeld = sterrenbeeld.stier;
            }
            else if ((datum.Month == 5 && datum.Day >= 21) || (datum.Month == 6 && datum.Day <= 21))
            {
                sbSterrenbeeld = sterrenbeeld.tweeling;
            }
            else if ((datum.Month == 6 && datum.Day >= 22) || (datum.Month == 7 && datum.Day <= 22))
            {
                sbSterrenbeeld = sterrenbeeld.kreeft;
            }
            else if ((datum.Month == 7 && datum.Day >= 23) || (datum.Month == 8 && datum.Day <= 22))
            {
                sbSterrenbeeld = sterrenbeeld.leeuw;
            }
            else if ((datum.Month == 8 && datum.Day >= 23) || (datum.Month == 9 && datum.Day <= 22))
            {
                sbSterrenbeeld = sterrenbeeld.maagd;
            }
            else if ((datum.Month == 9 && datum.Day >= 23) || (datum.Month == 10 && datum.Day <= 22))
            {
                sbSterrenbeeld = sterrenbeeld.weegschaal;
            }
            else if ((datum.Month == 10 && datum.Day >= 23) || (datum.Month == 11 && datum.Day <= 21))
            {
                sbSterrenbeeld = sterrenbeeld.schorpioen;
            }
            else
            {
                sbSterrenbeeld = sterrenbeeld.boogschutter;
            }
            string strSterrenbeeld = Convert.ToString(sbSterrenbeeld);
            return strSterrenbeeld;
        }
    }
}
