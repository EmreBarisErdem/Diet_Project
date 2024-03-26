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
    public partial class UserDetailScreen : Form
    {
        public UserDetailScreen(int personID)
        {
            InitializeComponent();
            this.personID = personID;
            personServices = new PersonServices();
        }
        int personID;
        PersonServices personServices;

        public void RefreshData(Person person)
        {
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDate.Text = person.BirthDate.Date.ToString();
            txtGender.Text = person.Gender.ToString();
            txtPassword.Text = person.Password;
            txtWeight.Text = person.Weight.ToString();
            txtHeight.Text = person.Height.ToString();
            txtActivityStatus.Text = person.ActivityStatus.ToString();
            txtCaloriesPDay.Text = person.CaloriesPerDay.ToString();
            txtUserStatus.Text = person.UserStatus.ToString();
        }

        private void UserDetailScreen_Load_1(object sender, EventArgs e)
        {
            Person person = personServices.GetPersonByID(personID);

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDate.Text = person.BirthDate.Date.ToString();
            txtGender.Text = person.Gender.ToString();
            txtPassword.Text = person.Password;
            txtWeight.Text = person.Weight.ToString();
            txtHeight.Text = person.Height.ToString();
            txtActivityStatus.Text = person.ActivityStatus.ToString();
            txtCaloriesPDay.Text = person.CaloriesPerDay.ToString();
            txtUserStatus.Text = person.UserStatus.ToString();

            if (person.UserStatus is UserStatus.Inactive)
            {
                btnUnBan.Enabled = true;
            }
            else
            {
                btnUnBan.Enabled = false;
            }
        }

        private void btnUnBan_Click_1(object sender, EventArgs e)
        {
            Person person = personServices.GetPersonByID(personID);

            person.UserStatus = UserStatus.Active;

            bool control = personServices.AddOrUpdate(person);

            if (control)
            {
                MessageBox.Show("User Activity Changed To Active", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A Problem Occured While Changing Status", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshData(person);
        }
    }
}
