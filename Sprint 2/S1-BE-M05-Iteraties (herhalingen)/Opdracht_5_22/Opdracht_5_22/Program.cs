using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_5_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //asigns the variables
            int g1 = 0;
            int g2 = 1;
            int g3 = 0;
            int som = 0;

            //calculates
            while (g1 + g2 < 4000000)
            {
                g3 = g1 + g2;
                g1 = g2;
                g2 = g3;
                Console.WriteLine(g3);
                System.Threading.Thread.Sleep(100);
                if (g3 % 2 == 0)
                {
                    som = som + g3;
                }
            }

                //shows the result
                Console.WriteLine("Als je alle even fibonacci getallen onder 4 milioen bij elkaar optelt krijg je:\n" + som);
            Console.ReadLine();
        }
    }
}
