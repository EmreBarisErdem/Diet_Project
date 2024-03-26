using CalorieProject_BLL.Services;
using CalorieProject_Models.Concretes;
using CalorieProject_Models.Enums;
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
    public partial class LogOnScreen : Form
    {
        public LogOnScreen()
        {
            InitializeComponent();
            personServices = new();
        }
        PersonServices personServices;

        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            cmb_ActvityStatus.DataSource = Enum.GetValues<ActivityStatus>();

            cmb_Gender.DataSource = Enum.GetValues<Gender>();

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            person.FirstName = txt_FirstName.Text.Trim();
            person.LastName = txt_LastName.Text.Trim();
            person.UserName = txt_UserName.Text;
            person.Password = txt_Password.Text;
            person.BirthDate = dtp_BirthDate.Value;
            person.UserStatus = UserStatus.Active;
            person.UserType = UserType.User;
            person.ActivityStatus = (ActivityStatus)cmb_ActvityStatus.SelectedItem;
            person.Gender = (Gender)cmb_Gender.SelectedItem;
            person.Weight = (double)nud_Weight.Value;
            person.Height = (double)nud_Height.Value;

            person.CalculateCaloriesPerDay(); //calculation of calories required per day depending of Age,Heigth,Gender and Weight

            bool isAdded = personServices.AddMember(person); // Inserting person info before controlling the requirements

            if (isAdded)
            {
                MessageBox.Show("Register Completed Succesfully", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            else
            {
                MessageBox.Show("!!A Problem Occured At Register!!\n!!Username Requires Unique And Must Be A Mail Adress!!\n!!Password Must Include Capital Letter And Special Char!!\n!!Age Must Be Between 18 And 40!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


    }
}
