using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeOne.Repository
{
    public class MenuRepository
    {
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
        
        // public Menu GetMenuItemByMealName(string mealName)
        // {
        //     foreach (Menu menu in _menuDB)
        //     {

        //     }
        // }



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


            Menu cheeseburger = new Menu(7, MealType.Lunch, "Cheeseburger", "High quality beef topped with cheese on a multigrain bun.", "ground beef patty, cheese, multigrain bun", 12.99);

            Menu[] menuArr = { belgianWaffle, pancakes, avocadoToast, cheeseburger };

            foreach (Menu menu in menuArr)
            {
                AddMenuItemToDatabase(menu);
            }
        }
    }
}