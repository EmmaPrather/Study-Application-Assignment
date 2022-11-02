using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Study_Application_Lists_Demo
{
    internal class Character
    {
        private string Name;
        private int Level;

        public Character(string charName, int charLevel)
        {
            Name = charName;
            Level = charLevel;
        }

        public void DisplayInfo()
        {
            WriteLine($" > {Name} ");
            WriteLine($"Level: {Level}");

        }
    }
}
