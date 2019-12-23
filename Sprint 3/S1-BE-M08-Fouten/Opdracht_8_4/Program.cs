using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;

namespace Opdracht_8_4
{
    class Program
    {
        //makes the user give an ip and uses PingHost to check if its valid
        static void Main(string[] args)
        {
            //defines the title of the console
            Console.Title = "Opdracht_8_4";


            //prints out the programs function
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(
                "**************************************************************************\n" +
                "*  Dit programma laat u een ip pingen en geeft aan of het succesvol was  *\n" +
                "**************************************************************************\n" +
                "\n");

            //assigns the variables
            string retry, ip;
            bool isNumber = false;
            bool isValid = false;


            //do while loop for if the user wants to run the program again
            do
            {
                //asks the user for an ip
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Geef een ip in.");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                ip = Console.ReadLine();


                //validates the input
                while (!isNumber || !isValid)
                {
                    if (!(IPAddress.TryParse(ip, out IPAddress result)))
                    {
                        isValid = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet moet een ip zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        ip = Console.ReadLine();

                    }
                    else if (!(ip.Contains(".")))
                    {
                        isNumber = false;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nHet moet een ip zijn!");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        ip = Console.ReadLine();
                    }
                    else
                    {
                        isValid = true;
                        isNumber = true;
                    }

                }
                Console.WriteLine("");


                //prints out wether the ping was succesfull or not
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (PingHost(ip))
                {
                    Console.WriteLine("De ping was succesvol!");
                }
                else
                {
                    Console.WriteLine("De ping was niet succesvol.");
                }


                //asks if the user wants to run the program again
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nWilt u het opnieuw proberen? (ja/nee)");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                retry = Console.ReadLine();


                //tries if the users input contains "ja" (dutch for yes) or "nee" (dutch for no)
                while (!(retry.ToLower().Contains("ja") || retry.ToLower().Contains("nee")))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nOngeldig. Geef \'ja\' of \'nee\' in.");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    retry = Console.ReadLine();
                }
                Console.Clear();
            } while (retry.ToLower().Contains("ja"));
        }
        //checks if a given ip is valid
        public static bool PingHost(string ip)
        {
            bool pingable = false;
            Ping ping = new Ping();
            PingReply reply;
            Console.WriteLine("Een moment gedult a.u.b.\n");
            reply = ping.Send(ip);

            if (reply.Status == IPStatus.Success)
            {
                pingable = true;
            }

            return pingable;
        }
    }
}
