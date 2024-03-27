using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
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
    public partial class OgundenYemekSec : Form
    {
        public OgundenYemekSec(int personID)
        {
            InitializeComponent();
            mealServices = new();
            foodServices = new();
            personServices = new();
            menuServices = new();
            menuFoodServices = new();

            this.personID = personID;

        }
        MealServices mealServices;
        FoodServices foodServices;
        PersonServices personServices;
        MenuServices menuServices;
        MenuFoodServices menuFoodServices;


        int personID;


        private void BreakFastCaloriesCalculator(out int totalCalories)
        {
            totalCalories = 0;


            foreach (Food food in lbox_Breakfast.Items)
            {

                food.TotalCalories = food.Quantity * food.Calories;

                if (food.Portion is Portion.Double)
                {
                    food.TotalCalories *= 2;
                }
                else if (food.Portion is Portion.Standart)
                {
                    food.TotalCalories *= 1;
                }
                else
                {
                    food.TotalCalories /= 2;
                }

                totalCalories += food.TotalCalories;

            }

            lbl_Breakfast_Calories.Text = $"{totalCalories} Calories";
        }

        private void LunchCaloriesCalculator(out int totalCalories)
        {
            totalCalories = 0;


            foreach (Food food in lbox_Lunch.Items)
            {

                food.TotalCalories = food.Quantity * food.Calories;

                if (food.Portion is Portion.Double)
                {
                    food.TotalCalories *= 2;
                }
                else if (food.Portion is Portion.Standart)
                {
                    food.TotalCalories *= 1;
                }
                else
                {
                    food.TotalCalories /= 2;
                }

                totalCalories += food.TotalCalories;

            }

            lbl_Lunch_Calories.Text = $"{totalCalories} Calories";
        }

        private void DinnerCaloriesCalculator(out int totalCalories)
        {
            totalCalories = 0;


            foreach (Food food in lbox_Dinner.Items)
            {

                food.TotalCalories = food.Quantity * food.Calories;

                if (food.Portion is Portion.Double)
                {
                    food.TotalCalories *= 2;
                }
                else if (food.Portion is Portion.Standart)
                {
                    food.TotalCalories *= 1;
                }
                else
                {
                    food.TotalCalories /= 2;
                }

                totalCalories += food.TotalCalories;

            }

            lbl_Dinner_Calories.Text = $"{totalCalories} Calories";
        }







        private void btn_AddFood_Click_1(object sender, EventArgs e)
        {
            if (lbox_Foods.SelectedIndex != -1)
            {
                Food food = (lbox_Foods.SelectedItem as Food);

                Food selectedFood = foodServices.GetByID(food.FoodID);

                selectedFood.Quantity = (int)nud_Quantity.Value;

                selectedFood.Portion = (Portion)cmb_Portion.SelectedItem;

                bool control = foodServices.AddOrUpdate(selectedFood);

                Meal meal = cmb_ChooseMeal.SelectedItem as Meal;


                if (meal.MealName == "Breakfast")
                {
                    lbox_Breakfast.Items.Add(selectedFood);

                    BreakFastCaloriesCalculator(out int totalCalories);


                }
                else if (meal.MealName == "Lunch")
                {
                    lbox_Lunch.Items.Add(selectedFood);
                    LunchCaloriesCalculator(out int totalCalories);
                }
                else
                {
                    lbox_Dinner.Items.Add(selectedFood);
                    DinnerCaloriesCalculator(out int totalCalories);
                }

            }
            else
            {
                MessageBox.Show("Please Select Any Food From The Food List", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbox_Foods_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Food food = (lbox_Foods.SelectedItem as Food);

            lbl_SelectedFood_Calories.Text = $"{food.Calories} Calories";

            nud_Quantity.Value = food.Quantity;

            cmb_Portion.SelectedItem = food.Portion;
        }

        private void btn_Remove_Breakfast_Click_1(object sender, EventArgs e)
        {
            if (lbox_Breakfast.Items.Count > 0 && lbox_Breakfast.SelectedIndex != -1)
            {
                lbox_Breakfast.Items.RemoveAt(lbox_Breakfast.SelectedIndex);

                BreakFastCaloriesCalculator(out int totalCalories);
            }
            else
            {
                MessageBox.Show("There is no food to be removed from the Breakfast Meal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remove_Lunch_Click_1(object sender, EventArgs e)
        {
            if (lbox_Lunch.Items.Count > 0 && lbox_Lunch.SelectedIndex != -1)
            {
                lbox_Lunch.Items.RemoveAt(lbox_Lunch.SelectedIndex);

                LunchCaloriesCalculator(out int totalCalories);
            }
            else
            {
                MessageBox.Show("There is no food to be removed from the Lunch Meal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remove_Dinner_Click(object sender, EventArgs e)
        {
            if (lbox_Dinner.Items.Count > 0 && lbox_Dinner.SelectedIndex != -1)
            {
                lbox_Dinner.Items.RemoveAt(lbox_Dinner.SelectedIndex);

                DinnerCaloriesCalculator(out int totalCalories);
            }
            else
            {
                MessageBox.Show("There is no food to be removed from the Dinner Meal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Transfer_Breakfast_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            MenuFoods menuFood = new MenuFoods();

            Meal meal = mealServices.GetMealByID(1); // 1 == Breakfast

            BreakFastCaloriesCalculator(out int calories);

            menu.TotalCaloriesByMeal = calories;
            menu.MealID = meal.MealID;

            Person person = personServices.GetPersonByID(personID);
            menu.PersonID = person.PersonID;

            bool control = menuServices.AddMenu(menu);

            List<MenuFoods> menuFoods = new List<MenuFoods>();

            menuFood.Menu = menu;

            if (lbox_Breakfast.Items.Count > 0)
            {
                foreach (Food food in lbox_Breakfast.Items)
                {
                    menuFood.Menu = menuServices.GetMenu(menu.MenuID);
                    menuFood.Food = foodServices.GetByID(food.FoodID);
                    menuFoods.Add(menuFood);
                    food.MenuFoods = menuFoods;
                    menu.MenuFoods = menuFoods;

                    menuFoodServices.AddOrUpdate(menuFood);
                }

                


                if (control)
                {

                    MessageBox.Show("Menu Added Succesfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("A Problem Happened While Adding!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lbox_Breakfast.Items.Clear();
                lbl_Breakfast_Calories.Text = "... Calories";
            }
            else
            {
                MessageBox.Show("There is No Food To Add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Transfer_Lunch_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            MenuFoods menuFood = new MenuFoods();

            Meal meal = mealServices.GetMealByID(2); // 2 == Lunch

            LunchCaloriesCalculator(out int calories);

            menu.TotalCaloriesByMeal = calories;
            menu.MealID = meal.MealID;

            Person person = personServices.GetPersonByID(personID);
            menu.PersonID = person.PersonID;

            bool control = menuServices.AddMenu(menu);

            List<MenuFoods> menuFoods = new List<MenuFoods>();

            menuFood.Menu = menu;

            if (lbox_Lunch.Items.Count > 0)
            {
                foreach (Food food in lbox_Lunch.Items)
                {
                    menuFood.Menu = menuServices.GetMenu(menu.MenuID);
                    menuFood.Food = foodServices.GetByID(food.FoodID);
                    menuFoods.Add(menuFood);
                    food.MenuFoods = menuFoods;


                    menuFoodServices.AddOrUpdate(menuFood);
                }


                menu.MenuFoods = menuFoods;


                if (control)
                {

                    MessageBox.Show("Menu Added Succesfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("A Problem Happened While Adding!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lbox_Lunch.Items.Clear();
                lbl_Lunch_Calories.Text = "... Calories";
            }
            else
            {
                MessageBox.Show("There is No Food To Add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btn_Transfer_Dinner_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            MenuFoods menuFood = new MenuFoods();

            Meal meal = mealServices.GetMealByID(3); // 3 == Dinner

            DinnerCaloriesCalculator(out int calories);

            menu.TotalCaloriesByMeal = calories;
            menu.MealID = meal.MealID;

            Person person = personServices.GetPersonByID(personID);
            menu.PersonID = person.PersonID;

            bool control = menuServices.AddMenu(menu);


            List<MenuFoods> menuFoods = new List<MenuFoods>();

            if (lbox_Dinner.Items.Count > 0)
            {
                foreach (Food food in lbox_Dinner.Items)
                {
                    menuFood.Menu = menuServices.GetMenu(menu.MenuID);
                    menuFood.Food = foodServices.GetByID(food.FoodID);
                    menuFoods.Add(menuFood);
                    food.MenuFoods = menuFoods;


                    menuFoodServices.AddOrUpdate(menuFood);
                }

                menu.MenuFoods = menuFoods;




                if (control)
                {

                    MessageBox.Show("Menu Added Succesfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("A Problem Happened While Adding!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                lbox_Dinner.Items.Clear();
                lbl_Dinner_Calories.Text = "... Calories";
            }
            else
            {
                MessageBox.Show("There is No Food To Add", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void OgundenYemekSec_Load_1(object sender, EventArgs e)
        {
            cmb_ChooseMeal.DataSource = mealServices.GetMeals();
            cmb_ChooseMeal.DisplayMember = "MealName";
            cmb_ChooseMeal.ValueMember = "MealID";

            lbox_Foods.DataSource = foodServices.GetAll();
            lbox_Foods.DisplayMember = "Name";
            //lbox_Foods.ValueMember = "FoodID";

            cmb_Portion.DataSource = Enum.GetValues<Portion>().ToList();
        }

        private void txt_SearchFood_TextChanged_1(object sender, EventArgs e)
        {
            lbox_Foods.DataSource = foodServices.GetFoodWithWords(txt_SearchFood.Text);
        }
    }
}
