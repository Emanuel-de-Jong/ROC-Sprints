using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emanuel_de_Jong_Opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumb = rnd.Next(1, 11);
            int chosenNumb = 0;
            int timesGuessed = 0;
            Console.WriteLine("Raad het getal\n" +
                "-------------------------------------");
            while(chosenNumb != rndNumb)
            {
                timesGuessed++;
                Console.Write("Uw gok (min. 1, max 10?) ");
                chosenNumb = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Gefeliciteerd, het getal was {0} en je hebt het in {1} keer geraden!\n" +
                "Druk op een willekeurige toets on af te sluiten ...", rndNumb, timesGuessed);
            Console.ReadLine();
        }
    }
}
