using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DiaperNotify
{
    public class Parent
    {
        //Gather user name
        public string name;
        public string Name => name;

        //Gather number of children to track
        public int numberOfKids;
        public int NumberOfKids => numberOfKids;


        //Gather user email information
        public string email;
        public string Email => email;

        //Double check if information is correct
        public void GatherParentInformation()
        {
            Write("Please enter your name: ");
            name = ReadLine();

            Write("Please enter the number of children in your household: ");
            numberOfKids = Int32.Parse(ReadLine());

            Write("Please enter your email: ");
            email = ReadLine();


            WriteLine("\nLet's double check to make sure we have everything we need.");
                WriteLine("\nName: {0}\nNumber of Children: {1}\nEmail Address: {2}", name, numberOfKids, email);

            while (true)
            {
                Write("Does all the information look correct?: ");
                string input = ReadLine();
                if (input.ToLower() == "y" || input.ToLower() == "yes")
                {
                    if (numberOfKids > 1)
                    {
                        WriteLine("Great! Let's learn more about the children");
                    }
                    else
                    {
                        //once we build child class this should reference the childs name
                        WriteLine("Great! Let's learn more about ...");
                    }
                    //maybe should be false
                    break;
                }
                else if (input.ToLower() == "n" || input.ToLower() == "no")
                {
                    WriteLine("\nLet's try that again..\n");
                    GatherParentInformation();
                }
                else
                {
                    WriteLine("\nPlease enter yes or no.\n");
                }
            }
        }
    }
}