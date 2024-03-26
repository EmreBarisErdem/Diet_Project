using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using Diet_BLL.Services;
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
            mealServices = new MealServices();
            personServices = new PersonServices();
        }
        int personID;
        MealServices mealServices;
        PersonServices personServices;

   /*

        private void btnDailyData_Click_1(object sender, EventArgs e)
        {
            DateTime selectedDate = DateTime.Now;

            Person person = personServices.GetPersonByID(personID);

            int totalCalories = 0;

            List<PersonMeal> personMeals = mealServices.GetDailyMeals(selectedDate, personID);


            foreach (PersonMeal personMeal in personMeals)
            {
                string[] personMealInfo = { personMeal.Meal.MealName, personMeal.Meal.MealDate.ToString(), personMeal.Meal.TotalCaloriesByMeal.ToString() };

                ListViewItem lvi = new ListViewItem(personMealInfo);

                lvi.Tag = personMeal;

                lvi_Meal.Items.Add(lvi);

                totalCalories += (int)personMeal.Meal.TotalCaloriesByMeal;
            }



            lbl_DailyTotalCalories.Text = $"{totalCalories} Calories";
            lbl_DailyMaxCalories.Text = $"{person.CaloriesPerDay} Calories";
        }
   */
    }
}
