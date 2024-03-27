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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            personServices = new();
            foodServices = new();

        }
        PersonServices personServices;
        FoodServices foodServices;



        private void btn_MemberBan_Click_1(object sender, EventArgs e)
        {
            Person person = lbox_Members.SelectedItem as Person;

            Person selectedPerson = personServices.GetPersonByUsername(person.UserName);

            if (selectedPerson.UserType != UserType.Admin)
            {
                selectedPerson.UserStatus = UserStatus.Inactive;

            }
            else
            {
                MessageBox.Show("You Can Not Ban Another Admin Be Careful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            bool control = personServices.AddOrUpdate(selectedPerson);

            if (control)
            {
                MessageBox.Show("User Activity Changed To Inactive ", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A Problem Occured While Changing Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            lbox_Members.DataSource = personServices.GetAll();
            lbox_Members.DisplayMember = "UserName";
            lbox_Members.ValueMember = "PersonID";

            RefreshFoodList();
        }

        private void btnDeleteFood_Click_1(object sender, EventArgs e)
        {


            Food selectedFood = lbox_Foods.SelectedItem as Food;

            bool control = foodServices.Delete(selectedFood);

            if (control)
            {
                MessageBox.Show("Food Deleted Succesfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A Problem Occured While Deleting", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lbox_Foods.DataSource = null;
            lbox_Foods.DataSource = foodServices.GetAll();
            lbox_Foods.DisplayMember = "Name";
        }

        private void lbox_Members_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            Person selectedPerson = lbox_Members.SelectedItem as Person;

            UserDetailScreen userDetailScreen = new UserDetailScreen(selectedPerson.PersonID);
            userDetailScreen.Show();
        }

        private void lbox_Foods_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Food food = lbox_Foods.SelectedItem as Food;

            Food selectedFood = foodServices.GetByID(food.FoodID);

            FoodDetailScreen foodDetailScreen = new FoodDetailScreen(selectedFood.FoodID);           

            foodDetailScreen.ShowDialog();

            RefreshFoodList();

            
        }

        private void RefreshFoodList()
        {           
            lbox_Foods.DataSource = null;

            lbox_Foods.DataSource = foodServices.GetAll();
            lbox_Foods.DisplayMember = "Name";
            lbox_Foods.ValueMember = "FoodID";
        }
    }
}
