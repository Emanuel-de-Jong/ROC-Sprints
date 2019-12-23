using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_4
{
    class Program
    {
        //calculates and tells the user what the endprice of a custom car is
        static void Main(string[] args)
        {
            //declaration of the variables
            string naam, metallicLak, lerenBekleding, automaat;
            double standaardPrijs, totaalPrijs, fivePer;

            //asking input
            Console.WriteLine("Wat is uw naam?");
            naam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is de standaardprijs?");
            standaardPrijs = Convert.ToDouble(Console.ReadLine());
            if (standaardPrijs < 0)
            {
                standaardPrijs = 0;
            }
            Console.WriteLine("Wilt u een metallic lak (ja/nee)?");
            metallicLak = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wilt u een leren bekleding (ja/nee)?");
            lerenBekleding = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wilt u een automaat i.p.v. handmatige schakeling (ja/nee)?");
            automaat = Convert.ToString(Console.ReadLine());

            //calculates the price and visualizes its changes
            Console.WriteLine("");
            Console.WriteLine("naam:                                    " + naam);
            Console.WriteLine("standaardprijs:                          " + standaardPrijs);
            totaalPrijs = standaardPrijs;
            fivePer = standaardPrijs * 0.05;
            if (metallicLak == "ja")
            {
                totaalPrijs = totaalPrijs + fivePer;
                Console.WriteLine("metallic lak:                            " + fivePer);
            }
            if (lerenBekleding == "ja")
            {
                totaalPrijs = totaalPrijs + fivePer;
                Console.WriteLine("leren bekleding:                         " + fivePer);
            }
            if (automaat == "ja")
            {
                totaalPrijs = totaalPrijs + 1000;
                Console.WriteLine("automaat i.p.v. handmatige schakeling:   1000");
            }
            Console.WriteLine("totaalprijs:                             " + totaalPrijs);
            Console.WriteLine("BTW:                                     " + totaalPrijs * 0.21);
            Console.WriteLine("totaalprijs inc. BTW:                    " + totaalPrijs * 1.21);
            Console.ReadLine();
        }
    }
}
