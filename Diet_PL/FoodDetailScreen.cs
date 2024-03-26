using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
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
    public partial class FoodDetailScreen : Form
    {
        public FoodDetailScreen(int foodID)
        {
            InitializeComponent();
            this.foodID = foodID;
            foodServices = new FoodServices();
            foodCategoryServices = new FoodCategoryServices();
        }
        int foodID;
        FoodServices foodServices;
        FoodCategoryServices foodCategoryServices;



        private void FoodDetailScreen_Load(object sender, EventArgs e)
        {
            cmbFoodCategory.DataSource = foodCategoryServices.GetAll();
            cmbFoodCategory.DisplayMember = "FoodCategoryName";
            cmbFoodCategory.ValueMember = "FoodCategoryID";


            Food food = foodServices.GetByID(foodID);
            FoodCategory foodCategory = foodCategoryServices.GetByID(food.FoodCategoryID);

            cmbFoodCategory.SelectedIndex = foodCategory.FoodCategoryID - 1; // Index 0 'dan başlıyor

            
            food.FoodCategory = foodCategory;

            txtFoodName.Text = food.Name;

            txtCalories.Text = food.Calories.ToString();

            pBoxFoodImg.ImageLocation = food.PicturePath;

        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            pBoxFoodImg.ImageLocation = null;
        }

        private void btnChangeImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            pBoxFoodImg.ImageLocation = openFileDialog.FileName;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Food food = foodServices.GetByID(foodID);


            food.Quantity = 1;
            food.Portion = Portion.Standart;
            food.Grams = 100;

            food.Name = txtFoodName.Text;

            bool control = int.TryParse(txtCalories.Text, out int calories);

            if (control)
            {
                food.Calories = calories;
            }
            else
            {
                MessageBox.Show("Please Enter A Number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            food.PicturePath = pBoxFoodImg.ImageLocation;


            control = foodServices.AddOrUpdate(food);
        }

    }
}
