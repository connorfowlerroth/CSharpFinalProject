using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeOne.ConsoleApp
{
    public class CustomConsole
    {
        // SINGLE RESPONSIBILITY 
        // Methods that print things in the console.
        public void PrintMainMenu()
        {
            Console.WriteLine("1. Create New Menu Item.\n" +
                                "2. Delete Menu Item.\n" +
                                    "3. List all Menu Items");
        }
    }
}