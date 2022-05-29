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

                UserInputPortal(userInput); 
            }
        }

        private void UserInputPortal(string inputFromUser)
        {
            switch (inputFromUser)
            {
                case "1":
                    CreateNewMenuItem();
                    break;
                case "2":
                    DeleteMenuItem();
                    break;
                case "3":
                    ListAllMenuItems();
                    break;
                case "4":
                    ExitApp();
                    break;
                default:
                    //InvalidInputReturnToMainMenu();
                    break;
            }
        }

        private void CreateNewMenuItem()
        {
            // Console.Clear();
            _console.EnterNewMealNumber();
            int newMenuNumber = _console.GetUserInputInt();

            _console.NewMealTypeSelection();
            string mealTypeSelection = _console.GetUserInput();

            MealType? newMealType = MealTypeSelection(mealTypeSelection);

            _console.EnterNewMealName();
            string newMealName = _console.GetUserInput();

            _console.EnterNewMealDescription();
            string newMealDescription = _console.GetUserInput();

            _console.EnterNewIngredientList();
            string newIngredientList = _console.GetUserInput();

            _console.EnterNewPrice();
            double newPrice = _console.GetUserInputDouble();

            // Constructor
            Menu newMenuItem = new Menu(newMenuNumber, newMealType, newMealName, newMealDescription, newIngredientList, newPrice);

            _repo.AddMenuItemToDatabase(newMenuItem);

            _console.PressAnyKeyToContinue();
        }

        public void ListAllMenuItems()
        {
            List<Menu> allMenuItems = _repo.GetAllMenuItems();

            _console.PrintAllMenuItems(allMenuItems);

            _console.PressAnyKeyToContinue();
        }
        public void ExitApp()
        {
            _console.Exit();
            _console.PressAnyKeyToContinue();
        }

        // CRUD ^^^^^
        // HELPERS vvvvv


        private MealType? MealTypeSelection(string userMealTypeInput)
        {
            switch(userMealTypeInput)
            {
                case "1":
                    return MealType.Breakfast;
                case "2":
                    return MealType.Lunch;
                default:
                    return null;
            }
        }
        //
    }
}