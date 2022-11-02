using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using static System.Console;

namespace Study_Application_Lists_Demo
{
    internal class PartySystem
    {
        List<Character> MyTeam;

        public PartySystem()
        {
            MyTeam = new List<Character>();

            MyTeam.Add(new Character("Main Player", 1));
           

        }

        public void Run()
        {
            WriteLine("=== Party Builder ===");
            WriteLine("Let's build a party!");

            //ToDo: make party from input
            string addResponse;
            do
            {
                Write("\nDo you want to add someone to your party? (yes/no) ");
                addResponse = ReadLine().Trim().ToLower();

                if (addResponse == "yes")
                {
                    Write("What is the character's name? ");
                    string name = ReadLine().Trim();
                    Write("What is the character's level? ");
                    int level = Convert.ToInt32(ReadLine()); //Can cause an error
                    Character newCharacter = new Character(name, level);
                    MyTeam.Add(newCharacter);
                    WriteLine("Added!");
                }
            } while (addResponse == "yes");

            //ToDo: display the party
            WriteLine("\nOkay, here's your team:");
            foreach (Character currentCharacter in MyTeam)
            {
                currentCharacter.DisplayInfo();
            }


        }





    }
}
