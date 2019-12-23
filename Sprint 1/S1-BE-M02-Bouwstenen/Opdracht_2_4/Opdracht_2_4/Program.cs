using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2_4
{
    class Program
    {
        //calculate the age of the user by asking for their birthdate
        static void Main(string[] args)
        {
            //declaration of the variables
            string naam;
            DateTime geboorteDatum;

            //asks the user to define naam and geboorteDatum
            Console.WriteLine("Wat is uw naam?");
            naam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Wat is uw geboortedatum (dd.mm.yyyy)?");
            geboorteDatum = Convert.ToDateTime(Console.ReadLine());

            //calculates the users age
            var nu = DateTime.Now;
            var leeftijd = nu.Year - geboorteDatum.Year;

            //shows the users age
            Console.WriteLine(naam+" is "+leeftijd+" jaar oud.");
            Console.ReadLine();
        }
    }
}
