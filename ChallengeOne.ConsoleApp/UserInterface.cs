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

            while (isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                // UserInputPortal(userInput);
            }
        }

        private void UserInput(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    //CreateNewMenuItem();
                    break;
                case "2":
                    //DeleteMenuItem();
                    break;
                case "3":
                    //ListAllMenuItems();
                    break;
                case "4":
                    //Exit();
                    break;
                default:
                    //InvalidInputReturnToMainMenu();
                    break;
            }
        }

        private void CreateNewMenuItem()
        {
            _console.EnterNewMealNumber();
            int newMenuNumber = _console.GetUserInput();

            _console.EnterMealType();
            bool

            _console.EnterNewMealName();
            string newMealName = _console.GetUserInput();

            _console.EnterNewMealDescription();
            string newMealDescription = _console.GetUserInput();
            _console.




        }
    }
}