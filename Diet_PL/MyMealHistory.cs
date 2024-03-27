using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using Diet_BLL.Services;
using Diet_Models.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet_PL
{
    public partial class MyMealHistory : Form
    {
        public MyMealHistory(int personID)
        {
            InitializeComponent();
            this.personID = personID;

            personServices = new PersonServices();
            menuServices = new MenuServices();
            foodServices = new FoodServices();
        }
        int personID;
        
        PersonServices personServices;
        MenuServices menuServices;
        FoodServices foodServices;

        private void btnDailyData_Click(object sender, EventArgs e)
        {

            lvi_Meal.Items.Clear();

            List<Menu> menus = menuServices.GetMenusForPeople(personID);

            Person person = personServices.GetPersonByID(personID);

            int totalCalories = 0; 

            foreach (Menu menu in menus)
            {
                string[] menuInfo = { menu.Meal.MealName, menu.MealDate.ToString(), menu.TotalCaloriesByMeal.ToString() };

                ListViewItem lvi = new ListViewItem(menuInfo);
                lvi.Tag = menu;

                lvi_Meal.Items.Add(lvi);

                totalCalories += menu.TotalCaloriesByMeal;
            }

            lbl_DailyTotalCalories.Text = totalCalories.ToString("0.00") + " Kcal";

            lbl_DifferenceCalories.Text = (person.CaloriesPerDay - totalCalories).ToString("0.00") + " Kcal";
        }

        private void lvi_Meal_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvi_Food.Items.Clear();

            Menu menu = (Menu)lvi_Meal.FocusedItem.Tag;

            Menu selectedMenu = menuServices.GetMenu(menu.MenuID);

            List<MenuFoods> menuFoods = foodServices.GetFoodFromMenu(selectedMenu.MenuID);

            foreach (MenuFoods menuFood in menuFoods)
            {
                string[] foodInfo = { menuFood.Food.FoodCategory.FoodCategoryName, menuFood.Food.Name, menuFood.Food.Quantity.ToString(), menuFood.Food.TotalCalories.ToString() };

                ListViewItem lvi = new ListViewItem(foodInfo);
                lvi.Tag = menuFood;

                lvi_Food.Items.Add(lvi);
            }
        }

        private void MyMealHistory_Load(object sender, EventArgs e)
        {
            Person person = personServices.GetPersonByID(personID);

            lbl_DailyMaxCalories.Text = person.CaloriesPerDay.ToString("0.00") + " Kcal";
        }
    }
}
