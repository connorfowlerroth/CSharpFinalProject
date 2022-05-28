using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeOne.Repository;

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
                                "3. List all Menu Items.\n" +
                                "4. Exit.\n");
            
        }

        public string GetUserInput()
        {
            return Console.ReadLine();
        }
        
        public int GetUserInputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double GetUserInputDouble()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public void EnterNewMealNumber()
        {
            Console.Clear();
            Console.Write("Enter Meal Number: ");
        }
        public void NewMealTypeSelection()
        {
            Console.Clear();
            Console.WriteLine("Enter Meal Type.\n\n" +
                                "1. Breakfast.\n" +
                                  "2. Lunch.\n");
        }

        public void EnterNewMealName()
        {
            Console.Clear();
            Console.Write("Enter Meal Name: ");
        }
        public void EnterNewMealDescription()
        {
            Console.Clear();
            Console.Write("Enter a Description: ");
        }
        public void EnterNewIngredientList()
        {
            Console.Clear();
            Console.Write("Enter Ingredient List: ");
        }
        public void EnterNewPrice()
        {
            Console.Clear();
            Console.Write("Enter a Price: ");
        }

        public void PrintMenuItems(Menu menuItems)
        {
            Console.WriteLine($"Meal #: {menuItems.MealNumber}\n" +
                            $"Meal Type: {menuItems.MealType}\n" +
                            $"Meal Name: {menuItems.MealName}\n" +
                            $"Meal Description: {menuItems.MealDescription}\n" +
                            $"Ingredients: {menuItems.IngredientList}\n" +
                            $"Meal Price: ${menuItems.MealPrice}\n");
        }
        public void PrintAllMenuItems(List<Menu> menuItems)
        {
            foreach(Menu x in menuItems)
            {
                PrintMenuItems(x);
            }
        }
        public void Exit()
        {
            Console.Clear();
            Console.WriteLine("Press any key to EXIT....");
            Console.ReadKey();
        }
        public void PressAnyKeyToContinue()
        {
            Console.Write("Press any key to continue....\n");
            Console.ReadKey();
            Console.Clear();
        }

        // 
    }
}