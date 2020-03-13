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

        public int ageInMonths;
        public int AgeInMonths => ageInMonths;

        public int averageDiaperUse;
        public int AverageDiaperuse => averageDiaperUse;

        public void GatherKidsInformation()
        {

            Write("\nPlease enter the number of children in your household: ");
            numberOfKids = Int32.Parse(ReadLine());

            String[] kidsNames = new string[numberOfKids];
            int[] agesInMonths = new int[numberOfKids];

            //Gathering children(s) name and corresponding age.
            if (numberOfKids == 1)
            {
                Write("\nWhat is your child's name?: ");
                kidsName = ReadLine();

                Write("\nHow old is {0} in months?", kidsName);
                ageInMonths = Int32.Parse(ReadLine());
            }
            else
            {
                for (int i = 0; i < kidsNames.Length; i++)
                {
                    Write("Please enter a childs name: ");
                    kidsNames[i] = ReadLine();

                    Write("How old is {0} in months?: ", kidsNames[i]);
                    agesInMonths[i] = Int32.Parse(ReadLine());
                    }
                }

        WriteLine("Here is what we have about the children so far");
            if (numberOfKids == 1)
            {
                WriteLine("{0} : {1} months old.", kidsName, ageInMonths);
            }
            else
            {
                for (int i = 0; i < kidsNames.Length; i++)
                {
                    WriteLine("{0} : {1} months old.", kidsNames[i], agesInMonths[i]);
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


        }
    }
}