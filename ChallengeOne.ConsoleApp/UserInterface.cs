using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeOne.Repository;

namespace ChallengeOne.ConsoleApp
{
    public class UserInterface
    {
        MenuRepository _repo = new MenuRepository();
        CustomConsole _console = new CustomConsole();
        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMenuData();

            while(isRunning)
            {
                _console.PrintMainMenu();
            }
        }
    }
}