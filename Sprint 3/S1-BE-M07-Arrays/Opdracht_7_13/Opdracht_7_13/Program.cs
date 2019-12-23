using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_7_13
{
    class Program
    {
        //shows the user a way to encrypt his input password
        static void Main(string[] args)
        {
            //defines the title of the console
            Console.Title = "Opdracht_7_13";


            //assigns the variables
            string retry, realPassword, hexadecimal;
            string randomKey;
            int randomNumber, tempSumRpavRkav;
            char[] basicChars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random rnd = new Random();


            //do while loop for if the user wants to run the program again
            do
            {
                //prints out the programs function
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(
                    "*********************************************************************************************\n" +
                    "*  Dit programma laat je een mogelijkheid om je ingegeven wachtwoord te versleutellen zien  *\n" +
                    "*********************************************************************************************\n" +
                    "\n");
                randomKey = "";
                //asks the user for a password
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Geef een wachtwoord in");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                realPassword = Console.ReadLine();


                //makes a string "randomKey" with random characters from basicChars with the same length as realPassword
                for (int i = 0; i < realPassword.Length; i++)
                {
                    randomNumber = rnd.Next(basicChars.Length);
                    randomKey += Convert.ToString(basicChars[randomNumber]);
                }

                //makes a int[] realPasswordASCIIValues"" with the ASCII values of realPassword
                int[] realPasswordASCIIValues = new int[realPassword.Length];
                for (int i = 0; i < realPassword.Length; i++)
                {
                    realPasswordASCIIValues[i] = (int)realPassword[i];
                }

                //makes a int[] "randomKeyASCIIValues" with the ASCII values of randomKey
                int[] randomKeyASCIIValues = new int[realPassword.Length];
                for (int i = 0; i < realPassword.Length; i++)
                {
                    randomKeyASCIIValues[i] = (int)randomKey[i];
                }

                //makes a int[] "sumRpavRkav" of the sum of realPasswordASCIIValues and randomKeyASCIIValues
                int[] sumRpavRkav = new int[realPassword.Length];
                int[] sumRpavRkavWithoutShorting = new int[realPassword.Length];
                for (int i = 0; i < realPassword.Length; i++)
                {
                    tempSumRpavRkav = realPasswordASCIIValues[i] + randomKeyASCIIValues[i];
                    sumRpavRkavWithoutShorting[i] = tempSumRpavRkav;
                    //ASCII values only go until 127, so if the sum is higher, it will be subtracted bij 127 to get a value between 0 and 127
                    if (tempSumRpavRkav <= 127)
                    {
                        sumRpavRkav[i] = tempSumRpavRkav;
                    }
                    else
                    {
                        tempSumRpavRkav = tempSumRpavRkav - 127;
                        sumRpavRkav[i] = tempSumRpavRkav;
                    }
                }

                //makes a string[] "hexadecimalSumrpavrkav" that have the values of sumRpavRkav as hexadecimal
                string[] hexadecimalSumrpavrkav = new string[realPassword.Length];
                for (int i = 0; i < realPassword.Length; i++)
                {
                    hexadecimal = sumRpavRkav[i].ToString("X");
                    //every string in hexadecimalSumrpavrkav should be 2 chars long, so if one is only 1 char long, it will add a 0 to the beginning
                    if (hexadecimal.Length == 2)
                    {
                        hexadecimalSumrpavrkav[i] = hexadecimal;
                    }
                    else
                    {
                        hexadecimal = "0" + hexadecimal;
                        hexadecimalSumrpavrkav[i] = hexadecimal;
                    }
                }


                //prints out all values in a hand writen table
                string forPrint;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("");
                Console.SetCursorPosition(0, 8);
                Console.Write("wachtwoord:");
                Console.SetCursorPosition(20, 8);
                Console.Write("ASCII van ww:");
                Console.SetCursorPosition(40, 8);
                Console.Write("key:");
                Console.SetCursorPosition(60, 8);
                Console.Write("ASCII van key:");
                Console.SetCursorPosition(80, 8);
                Console.Write("ASCII ww + ASCII key:");
                Console.SetCursorPosition(110, 8);
                Console.Write("hexadecimaal van ASCII ww + ASCII key:");
                for (int i = 0; i < realPassword.Length; i++)
                {
                    forPrint = sumRpavRkavWithoutShorting[i] + " -> " + sumRpavRkav[i];
                    Console.WriteLine("");
                    Console.SetCursorPosition(0, i + 10);
                    Console.Write(realPassword[i]);
                    Console.SetCursorPosition(20, i + 10);
                    Console.Write(realPasswordASCIIValues[i]);
                    Console.SetCursorPosition(40, i + 10);
                    Console.Write(randomKey[i]);
                    Console.SetCursorPosition(60, i + 10);
                    Console.Write(randomKeyASCIIValues[i]);
                    if (sumRpavRkav[i] == sumRpavRkavWithoutShorting[i])
                    {
                        Console.SetCursorPosition(80, i + 10);
                        Console.Write(sumRpavRkav[i]);
                        Console.SetCursorPosition(110, i + 10);
                        Console.Write(hexadecimalSumrpavrkav[i]);
                    }
                    else
                    {
                        Console.SetCursorPosition(80, i + 10);
                        Console.Write(forPrint);
                        Console.SetCursorPosition(110, i + 10);
                        Console.Write(hexadecimalSumrpavrkav[i]);
                    }

                }
                Console.WriteLine("");


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
    }
}
