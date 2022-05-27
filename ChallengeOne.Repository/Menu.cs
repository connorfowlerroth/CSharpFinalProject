using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeOne.Repository
{
    public class Menu
    {
        // PROPERTIES 
        public int MealNumber { get; set; }

        public MealType MealType { get; set; }

        public string MealName { get; set; }

    public string MealDescription { get; set; }

        public string IngredientList { get; set; }

        public double MealPrice { get; set; }

        // FULL CONSTRUCTOR 
        public Menu(int mealNumber, MealType mealType, string mealName, string mealDescription, string ingredientList, double mealPrice)
        {

            MealNumber = mealNumber;
            MealType = MealType;
            MealName = mealName;
            MealDescription = mealDescription;
            IngredientList = ingredientList;
            MealPrice = mealPrice;
        }
        // EMPTY CONSTRUCTOR 
        public Menu() {}
    }

    // ENUMS
    public enum MealType { Breakfast, Lunch }
}