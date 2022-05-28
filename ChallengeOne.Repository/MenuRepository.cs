using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeOne.Repository
{
    public class MenuRepository
    {
        // EMPTY CONSTRUCTOR
        public MenuRepository() { }

        // FAKE DB
        List<Menu> _menuDB = new List<Menu>();


        // CREATE
        public void AddMenuItemToDatabase (Menu menu)
        {
            _menuDB.Add(menu);
        }



        // READ
        public List<Menu> GetAllMenuItems()
        {
            return _menuDB;
        }
        
        public Menu GetMenuItemByMealName(string mealName)
        {
            foreach (Menu menu in _menuDB)
            {
                if(mealName.ToUpper() == menu.MealName.ToUpper())
                {
                    return menu;
                }
            }
            return null;
        }



        // UPDATE


        // DELETE
        public bool DeleteMenuItemFromDatabase(Menu menu)
        {
            int totalMenuItemsInDB = _menuDB.Count();

            _menuDB.Remove(menu);

            if(totalMenuItemsInDB == _menuDB.Count())
            {
                return false;
            }

                return true;
        }

        // SEED DATA METHOD 
        public void SeedMenuData()
        {
            Menu belgianWaffle = new Menu(1, MealType.Breakfast, "Belgian Waffle", "Light and airy Belgian Waffle topped with strawberries and powdered sugar.", "flour, milk, eggs", 14.95);
            Menu pancakes = new Menu(2, MealType.Breakfast, "Pancakes", "Classic homemade pancakes served with organic maple syrup.", "flour, sugar, milk, eggs, butter", 10.47);
            Menu avocadoToast = new Menu(3, MealType.Breakfast, "Avocado Toast", "Two pieces of perfectly toasted multigrain bread topped with mashed organic California avocados drizzled with olive oil and sea salt.", "multigrain bread, organic avocado, butter, olive oil,sea salt", 17.49);
            Menu hamAndSwissMelt = new Menu(4, MealType.Lunch, "Ham and Cheese Melt", "A slightly sweet and super-crisp cheese crust Ham and Swiss melt served with honey mustard and a pickle.", "spiral ham, swiss cheese, honey mustard, multigrain bread ", 14.95);
            Menu grilledChickenKaleSalad = new Menu(5, MealType.Lunch, "Grilled Chicken Kale Salad", "Juicy grilled chicken on fresh kale salad.", "organic  kale, organic grass-fed chicken", 11.99);
            Menu grilledCheese = new Menu(6, MealType.Lunch, "Grilled Cheese", "Buttery crisp grilled cheese with a pickle and chips.", "butter, American cheese, multigrain bread", 12.99);
            Menu cheeseburger = new Menu(7, MealType.Lunch, "Cheeseburger", "High quality beef topped with cheese on a multigrain bun.", "ground beef patty, cheese, multigrain bun", 12.99);

            Menu[] menuArr = { belgianWaffle, pancakes, avocadoToast, hamAndSwissMelt, grilledChickenKaleSalad, grilledCheese, cheeseburger };

            foreach (Menu menu in menuArr)
            {
                AddMenuItemToDatabase(menu);
            }
        }
    }
}