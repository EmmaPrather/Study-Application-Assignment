using System;
using System.Collections.Generic;
using static System.Console;

namespace Study_Application_Lists_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Title = "=== Lists Demo ===";
             WriteLine("Let's learn about lists!");

             List<string> inventory = new List<string>();

             // Array, you use .Length, but with a List, you use .Count.
             WriteLine($"You currently have {inventory.Count}x items.");

             inventory.Add("A Stick");
             inventory.Add("Rusty Sword");
             inventory.Add("Shiny Gem");
             inventory.Insert(0,"Pot of Gold");

             WriteLine($"You currently have {inventory.Count}x items.");

             WriteLine("\nYour current inventory:");

            // for (int i = 0; i < inventory.Count; i++)
            // {
           //     WriteLine($"> {inventory[i]}");
            // }
             foreach(string item in inventory)
             {
                 WriteLine($">{item}");
             }
 */
            PartySystem myParty = new PartySystem();
            myParty.Run();

            WriteLine("\nPress any key to ext...");
            ReadKey();

        }

      
        }
    }


