using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //makes an integer array with a length of 30
            int[] numbers = new int[30];

            //fills the array with random numbers between 1 and 150
            for (int i=0; i<30; i++)
            {
                numbers[i] = random.Next(1, 151);
            }

            //tests input of the user
            Console.WriteLine("Geef een nummer tussen de 1 en 30:");
            int number;
            while (true)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    //tests the range
                    if (number < 1 || number > 30)
                    {
                        Console.WriteLine("Het nummer is niet tussen 1 en 30!");
                    }
                    else
                    {
                        break;
                    }
                }
                //tests the convert
                catch (FormatException)
                {
                    Console.WriteLine("De ingave is geen nummer!");
                }
                //outputs any other errors
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            //outputs the item in 'numbers' with the index of the number given by the user
            Console.WriteLine(ReturnArrayItem(numbers, number) + "\n");

            Console.WriteLine("Druk op enter.");
            Console.ReadLine();
            //outputs all numbers and their parity in 'numbers'
            ArrayItemsEvenOrOdd(numbers);
            
            Console.Write("\nDruk op Enter om af te sluiten...");
            Console.ReadLine();
        }

        //outputs the item in the given integer array with the index of the given number
        //has the array as parameter to make it general use
        public static int ReturnArrayItem(int[] array, int number)
        {
            return array[number];
        }

        //outputs all numbers and their parity in the given integer array
        public static void ArrayItemsEvenOrOdd(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " = ");
                if (item % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.WriteLine("oneven");
                }
            }
        }
    }
}
