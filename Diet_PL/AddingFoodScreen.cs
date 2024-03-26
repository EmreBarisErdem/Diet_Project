using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using Diet_Models.Concretes;
using Microsoft.IdentityModel.Tokens;
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
    public partial class AddingFoodScreen : Form
    {
        public AddingFoodScreen()
        {
            InitializeComponent();
            foodServices = new();
            foodCategoryServices = new();
            food = new();
        }
        FoodServices foodServices;
        FoodCategoryServices foodCategoryServices;
        Food food;

    
        private void btn_AddFoodDetails_Click_1(object sender, EventArgs e)
        {

            if (foodServices.IsNameValid(txt_FoodName.Text) && !txt_FoodName.Text.IsNullOrEmpty())
            {
                food.Name = txt_FoodName.Text;
            }
            else
            {
                MessageBox.Show("Food Name Must Contains Only Letters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            food.FoodCategory = (FoodCategory)cmb_Categori.SelectedItem;
            food.PicturePath = pboxImage.ImageLocation;



            bool control = int.TryParse(txt_Calorie.Text, out int calorie);
            bool addControl = false;

            if (control && !txt_Calorie.Text.IsNullOrEmpty())
            {
                bool calorieControl = foodServices.CheckIsCalorieValid(calorie);

                if (calorieControl)
                {
                    food.Calories = calorie;



                    addControl = foodServices.AddOrUpdate(food);

                    if (addControl)
                    {
                        MessageBox.Show("Food Added Succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Problem Occured While Adding Food", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please Enter A Reasonable Value '< 1000 kcal'");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Calories As Numbers (kcal)");
            }


        }

        private void btn_AddImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            pboxImage.ImageLocation = ofd.FileName;
        }

        private void AddingFoodScreen_Load_1(object sender, EventArgs e)
        {
            cmb_Categori.DataSource = foodCategoryServices.GetAll();
            cmb_Categori.DisplayMember = "FoodCategoryName";
            cmb_Categori.ValueMember = "FoodCategoryID";
        }
    }
}
