using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DiaperNotify
{
    public class Kids
    {
        public string kidsName;
        public string KidsName => kidsName;

        public int numberOfKids;
        public int NumberOfKids => numberOfKids;

        public int diaperSize;
        public int DiaperSize => diaperSize;

        //pampers specified average diapers per day based on size starting at newborn
        public static readonly int[] AVG_DIAPERS_PER_DAY = { 8, 7, 6, 5, 5, 4, 4 };

        public void GatherKidsInformation()
        {
            //TRY BLOCK
            Write("\nPlease enter the number of children in your household: ");
            numberOfKids = Int32.Parse(ReadLine());

            String[] kidsNames = new string[numberOfKids];
            int[] diaperSizes = new int[numberOfKids];

            //Gathering children(s) name and corresponding age.
            if (numberOfKids == 1)
            {
                Write("\nWhat is your child's name?: ");
                kidsName = ReadLine();

                //THIS NEEDS TO BE REWORKED TO COME BACK AFTER EXCEPTION IS THROWN
                try
                {
                    Write("\nWhat size diaper is {0} wearing? enter 0 for newborn: ", kidsName);
                    diaperSize = Int32.Parse(ReadLine());

                    while (true)

                        if (diaperSize <= 6)
                        {
                            break;
                        }
                        else
                        {
                            Write("Please enter a diaper size 0 - 6 : ");
                            diaperSize = Int32.Parse(ReadLine());
                        }
                }
                catch (FormatException e)
                {
                    WriteLine("Please enter a valid diaper size.", e);
                }
            }
            else
            {
                for (int i = 0; i < kidsNames.Length; i++)
                {
                    Write("Please enter a childs name: ");
                    kidsNames[i] = ReadLine();

                    //THIS NEEDS TO BE REWORKED TO COME BACK AFTER EXCEPTION IS THROWN
                    try
                    {
                        Write("What size diaper is {0} wearing? enter 0 for newborn: ", kidsNames[i]);
                        diaperSizes[i] = Int32.Parse(ReadLine());
                        while (true)

                            if (diaperSize <= 6)
                            {
                                break;
                            }
                            else
                            {
                                Write("Please enter a diaper size 0 - 6 : ");
                                diaperSize = Int32.Parse(ReadLine());
                            }
                    }
                    catch (FormatException e)
                    {
                        WriteLine("Please enter a valid diaper size.", e);
                    }

                }
            }

            //verifying children information
            WriteLine("Here is what we have about the children so far");
            if (numberOfKids == 1)
            {
                WriteLine("{0} is wearing a {1} size diaper.", kidsName, diaperSize);
            }
            else
            {
                for (int i = 0; i < kidsNames.Length; i++)
                {
                    WriteLine("{0} is wearing a {1} size diaper", kidsNames[i], diaperSizes[i]);
                }
            }
            while (true)
            {
                //Prompt user to fix mistakes
                Write("Does all the information look correct?: ");
                string input = ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    WriteLine("Great! Let's continue");
                    break;
                }

                else if (input.ToLower() == "n" || input.ToLower() == "no")
                {
                    WriteLine("\nLet's try that again..\n");
                    GatherKidsInformation();
                }

                else
                {
                    WriteLine("\nPlease enter yes or no.\n");
                }
            }

            //WE WILL RUN PARRALLEL ARRAY WITH THE SIZE AND THE AVG USE.
            WriteLine("How is {0}'s daily diaper usage?");
            WriteLine("Below Average: ");

        }
    }
}