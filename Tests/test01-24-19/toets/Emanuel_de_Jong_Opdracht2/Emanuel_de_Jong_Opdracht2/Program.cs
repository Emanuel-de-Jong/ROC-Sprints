using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanuel_de_Jong_Opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            double teBetalen = 0;
            string product = String.Empty;
            int keuze;
            double geld;
            Console.WriteLine("" +
                "1.  Coca-Cola (1 euro)\n" +
                "2.  Fanta (1 euro)\n" +
                "3.  Spa blauw (0,75 euro)\n" +
                "4.  Red bull (1,50 euro)\n"
                );
            Console.WriteLine("keuze: ");
            keuze = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nGeld: ");
            geld = Convert.ToDouble(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    teBetalen = 1.0;
                    product = "Coca-Cola";
                    break;
                case 2:
                    teBetalen = 1.0;
                    product = "Fanta";
                    break;
                case 3:
                    teBetalen = 0.75;
                    product = "Spa blauw";
                    break;
                case 4:
                    teBetalen = 1.5;
                    product = "Red bull";
                    break;
            }

            Console.WriteLine();
            if (geld < teBetalen)
            {
                Console.WriteLine("Het bedrag is niet voldoende.");
            }
            else if (geld > teBetalen)
            {
                Console.WriteLine("Het bestelde product, {0}, wordt uitgeleverd en er wordt {1}, euro wisselgeld geretourneerd.", product, Math.Round(geld - teBetalen, 2));
            }
            else
            {
                Console.WriteLine("Het bestelde product, {0}, wordt uitgeleverd.", product);
            }

            Console.ReadLine();
        }
    }
}
