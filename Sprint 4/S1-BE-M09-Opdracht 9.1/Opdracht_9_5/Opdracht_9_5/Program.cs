using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace Opdracht_9_5
{
    //This program lets you set working alarms
    class Program
    {
        static void Main(string[] args)
        {
            //displays the function of the program
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(
                "+--------------------------------------------------------------------+\n" +
                "| Dit programma laat u alarmen met geluid en een beschrijfing zetten |\n" +
                "+--------------------------------------------------------------------+"
                );
            Console.ReadLine();


            //loops the setup of the alarms until the user is satisfied
            string restartProgram = "ja";

            while (restartProgram.Contains("ja"))
            {
                Console.Clear();
                

                //assigns the variables
                string[] alarm;

                string dateType = String.Empty;
                string date = String.Empty;
                string time = String.Empty;
                string chosenSound = String.Empty;
                string soundDirectory = String.Empty;
                string soundPreview = String.Empty;
                string description = String.Empty;
                string satisfiedWithSound = String.Empty;
                string alarmIsRight = String.Empty;
                string change = String.Empty;

                bool inputIncorrect = true;
                bool repeatSoundSelect = true;
                bool repeatAlarmCorrection = true;

                SoundPlayer sound = new SoundPlayer();


                //lets the user choose the date, time, sound and description of the alarm
                dateMethode(ref inputIncorrect, ref dateType, ref date);

                timeMethode(ref inputIncorrect, ref time);

                soundSelectMethode(ref repeatSoundSelect, ref inputIncorrect, ref chosenSound, ref soundDirectory, ref soundPreview, ref sound, ref satisfiedWithSound);

                descriptionMethode(ref description);


                while (repeatAlarmCorrection)
                {
                    while (inputIncorrect)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Uw klok staat momenteel op:" +
                            "\n   datum: " + date +
                            "\n   tijd: " + time +
                            "\n   geluid: " + chosenSound +
                            "\n   beschrijfing: " + description);
                        Console.WriteLine("\nIs dit korrekt? \"ja\" of \"nee\"");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        alarmIsRight = Console.ReadLine().ToLower();

                        //tests if the input was correct
                        if (alarmIsRight == "ja" || alarmIsRight == "nee")
                        {
                            inputIncorrect = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("U heeft geen \"ja\" of \"nee\" ingegeven!");
                        }
                    }
                    inputIncorrect = true;
                    Console.Clear();

                    if (alarmIsRight.Contains("nee"))
                    {
                        while (inputIncorrect)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(0, 1);
                            Console.WriteLine("Wat wilt u veranderen?");
                            Console.WriteLine("\"de datum\", \"de tijd\", \"het geluid\" of \"de beschrijfing\".");
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine();
                            change = Console.ReadLine().ToLower();

                            //tests if the input was one of the choices
                            if(change == "de datum" || change == "de tijd" || change == "het geluid" || change == "de beschrijfing")
                            {
                                inputIncorrect = false;
                            }
                            if (inputIncorrect)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(0, 0);
                                Console.WriteLine("De gegeven sectie zit niet tussen de keuzes.");
                            }
                        }
                        inputIncorrect = true;
                        Console.Clear();

                        switch (change)
                        {
                            case "de datum":
                                dateMethode(ref inputIncorrect, ref dateType,ref date);
                                break;
                            case "de tijd":
                                timeMethode(ref inputIncorrect, ref time);
                                break;
                            case "het geluid":
                                soundSelectMethode(ref repeatSoundSelect, ref inputIncorrect, ref chosenSound,ref soundDirectory, ref soundPreview, ref sound, ref satisfiedWithSound);
                                break;
                            case "de beschrijfing":
                                descriptionMethode(ref description);
                                break;
                        }
                    }
                    else
                    {
                        repeatAlarmCorrection = false;
                    }
                    Console.Clear();
                }
                
                //gives the collected information into the string[] "alarm"
                alarm = new string[] { date + ";" + time + ";" + chosenSound + ";" + description };

                //writes the information to commaSeparatedFile.csv
                File.AppendAllLines(Environment.CurrentDirectory + "\\storingFiles\\commaSeparatedFile.csv", alarm);


                while (inputIncorrect)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Wilt u nog een alarm instellen? \"ja\" of \"nee\"");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                    restartProgram = Console.ReadLine().ToLower();

                    //tests if the input was correct
                    if (restartProgram == "ja" || restartProgram == "nee")
                    {
                        inputIncorrect = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("U heeft geen \"ja\" of \"nee\" ingegeven!");
                    }
                }
            }
            List<string> alarms = File.ReadAllLines(Environment.CurrentDirectory + "\\storingFiles\\commaSeparatedFile.csv").ToList();
            string[] arrTemp;
            string strTemp = String.Empty;
            SoundPlayer sound2 = new SoundPlayer();
            string d;
            string t;
            string s;
            string b;
            for (int i = 0; i < alarms.Count; i++)
            {
                Console.WriteLine(DateTime.Now + "\n");
                foreach (string alarm in alarms)
                {
                    Console.WriteLine(alarm);
                }
                strTemp = alarms[i];
                strTemp = strTemp.Trim('"');
                arrTemp = strTemp.Split(';');
                d = arrTemp[0];
                t = arrTemp[1];
                s = arrTemp[2];
                b = arrTemp[3];
                switch (d)
                {
                    case "alle dagen":
                        if (DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "werkdagen":
                        if (DateTime.Now.DayOfWeek < DayOfWeek.Saturday && DateTime.Now.DayOfWeek > DayOfWeek.Sunday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "weekenden":
                        if ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday) && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "maandag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "dinsdag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "woensdag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "donderdag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "vrijdag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "saterdag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    case "zondag":
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday && DateTime.Now > DateTime.Parse(t) && DateTime.Now < DateTime.Parse(t).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                        }
                        break;
                    default:
                        if (DateTime.Now > DateTime.ParseExact(d + " " + t, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")) && DateTime.Now < DateTime.ParseExact(d + " " + t, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.GetCultureInfo("nl-NL")).AddSeconds(5))
                        {
                            testtest(sound2, i, s, b);
                            alarms.RemoveAt(i);
                        }
                        break;
                }
                if (i == alarms.Count - 1)
                {
                    i = 0;
                }
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
        }










        static void testtest(SoundPlayer sound2, int i, string s, string b)
        {
            sound2 = new SoundPlayer(Environment.CurrentDirectory + "\\sounds\\" + s + ".wav");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int index = 0; index < 10; index++)
            {
                sound2.Play();
                if (index % 2 == 0)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Clear();
                Console.Write("Alarm " + i + "\n\n" + "Description:\n" + b);
                System.Threading.Thread.Sleep(1000);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void dateMethode(ref bool inputIncorrect, ref string dateType,ref string date)
        {
            //lets the user choose when the alarm should go off
            while (inputIncorrect)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("Wanneer wilt u een alarm af laten gaan?");
                Console.WriteLine("Kies uit: \"datum\", \"alle dagen\", \"werkdagen\", \"weekenden\" of \"een specifieke dag\".");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                dateType = Console.ReadLine().ToLower();

                //tests if the input was one of the choices
                if(dateType == "datum" || dateType == "alle dagen" || dateType == "werkdagen" || dateType == "weekenden" || dateType == "een specifieke dag")
                {
                    inputIncorrect = false;
                }
                if (inputIncorrect)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("De gegeven datum zit niet tussen de keuzes.");
                }
            }
            inputIncorrect = true;
            Console.Clear();

            //lets the user decide what date or specific day he wants the alarm to be
            date = dateType;
            switch (dateType)
            {
                case "datum":
                    while (inputIncorrect)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Geef een datum in. (dd-mm-yyyy)");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        date = Console.ReadLine().ToLower();

                        //tests if the input is a date
                        inputIncorrect = !(DateTime.TryParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"), System.Globalization.DateTimeStyles.None, out DateTime result));
                            if (inputIncorrect)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("De ingave is geen datum.");
                        }
                    }
                    inputIncorrect = true;
                    break;
                case "een specifieke dag":
                    while (inputIncorrect)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Geef een dag in.");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        date = Console.ReadLine().ToLower();

                        //tests if the input is a weekday
                        if(date == "zondag" || date == "maandag" || date == "dinsdag" || date == "woensdag" || date == "donderdag" || date == "vrijdag" || date == "zaterdag")
                        {
                            inputIncorrect = false;
                        }
                        if (inputIncorrect)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("De gegeven dag bestaat niet.");
                        }
                    }
                    inputIncorrect = true;
                    break;
            }
            Console.Clear();
        }





        static void timeMethode(ref bool inputIncorrect, ref string time)
        {
            //lets the user give a time
            while (inputIncorrect)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("Geef een tijd in. (hh:mm)");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                time = Console.ReadLine();

                //tests if the input is a time
                inputIncorrect = !(DateTime.TryParseExact(time, "HH:mm", System.Globalization.CultureInfo.GetCultureInfo("nl-NL"), System.Globalization.DateTimeStyles.None, out DateTime result));
                if (inputIncorrect)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("De ingave is geen tijd.");
                }
            }
            inputIncorrect = true;
            Console.Clear();
        }





        static void soundSelectMethode(ref bool repeatSoundSelect, ref bool inputIncorrect, ref string chosenSound, ref string soundDirectory, ref string soundPreview, ref SoundPlayer sound, ref string satisfiedWithSound)
        {
            while (repeatSoundSelect)
            {
                //lets the user choose the sound played when the alarm goes off
                Console.ForegroundColor = ConsoleColor.White;
                while (inputIncorrect)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Welk geluid wilt u laten afspelen?");
                    Console.WriteLine("Kies uit: \"normaal\", \"dubbele tik\", \"boot hoorn\" of \"luchtalarm\".");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                    chosenSound = Console.ReadLine().ToLower();

                    //tests if the input was one of the choices
                    if(chosenSound == "normaal" || chosenSound == "dubbele tik" || chosenSound == "boot hoorn" || chosenSound == "luchtalarm")
                    {
                        inputIncorrect = false;
                    }
                    if (inputIncorrect)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("Het gegeven geluid zat niet tussen de keuzes.");
                    }
                }
                inputIncorrect = true;
                Console.Clear();

                //assigns the string "soundDirectory" to the directory of the chosen sound
                switch (chosenSound)
                {
                    case "normaal":
                        soundDirectory = Environment.CurrentDirectory + "\\sounds\\normaal.wav";
                        break;
                    case "dubbele tik":
                        soundDirectory = Environment.CurrentDirectory + "\\sounds\\dubbele tik.wav";
                        break;
                    case "boot toeter":
                        soundDirectory = Environment.CurrentDirectory + "\\sounds\\boot hoorn.wav";
                        break;
                    case "luchtalarm":
                        soundDirectory = Environment.CurrentDirectory + "\\sounds\\luchtalarm.wav";
                        break;
                }


                //asks if the user wants a preview of the sound
                while (inputIncorrect)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Wilt u een preview van uw gekozen geluid? \"ja\" of \"nee\"");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine();
                    soundPreview = Console.ReadLine().ToLower();

                    //tests if the input was correct
                    if (soundPreview == "ja" || soundPreview == "nee")
                    {
                        inputIncorrect = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(0, 0);
                        Console.WriteLine("U heeft geen \"ja\" of \"nee\" ingegeven!");
                    }
                }
                inputIncorrect = true;
                Console.Clear();

                //plays the sound and lets the user decide if he wants to choose a different sound
                if (soundPreview.Contains("ja"))
                {
                    sound = new SoundPlayer(soundDirectory);
                    sound.Play();

                    while (inputIncorrect)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("Bent u tevreden met het geluid of wilt u een ander geluid uitzoeken? \"tevreden\" of \"ander geluid\"");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine();
                        satisfiedWithSound = Console.ReadLine().ToLower();

                        //tests if the input was correct
                        if (satisfiedWithSound == "tevreden" || satisfiedWithSound == "ander geluid")
                        {
                            inputIncorrect = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("U heeft de vraag niet goed beantwoord.");
                        }
                    }
                    inputIncorrect = true;

                    //if the user is satisfied with the sound, the sound selection won't repeat
                    if (satisfiedWithSound.Contains("tevreden"))
                    {
                        repeatSoundSelect = false;
                    }
                }

                //if the user doesn't want to hear the preview, the sound selection won't repeat
                else
                {
                    repeatSoundSelect = false;
                }
                Console.Clear();
            }
            repeatSoundSelect = true;
        }





        static void descriptionMethode(ref string description)
        {
            //lets the user input a description for the alarm
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Geef een beschrijfing voor het alarm.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            description = Console.ReadLine();
            Console.Clear();
        }
    }
}
