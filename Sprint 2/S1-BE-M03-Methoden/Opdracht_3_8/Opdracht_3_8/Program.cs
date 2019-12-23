using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3_8
{
    class Program
    {   //generates a username from a name
        static void Main(string[] args)
        {
            //assigns the variables
            string voornaam, tussenvoegsel, achternaam, username;

            //asks for the input
            Console.WriteLine("Dit programma maakt een username met behulp van uw voledige naam.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Geef uw voornaam in.");
            voornaam = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Geef uw tussenvoegsel in. Als u geen tussenvoegsel heeft, vul dan  niets in.");
            tussenvoegsel = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Geef uw achternaam in.");
            achternaam = Convert.ToString(Console.ReadLine());

            //generates username
            username = voornaam.ToLower()[0] + achternaam.ToLower() + (voornaam.Length + tussenvoegsel.Length + achternaam.Length);
            Console.WriteLine(username);
            Console.ReadLine();
        }
    }
}
