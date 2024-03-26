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
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
            personServices = new();
        }
        PersonServices personServices;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text.Trim();

            Person person = personServices.GetPersonByUsername(username);

            bool control = personServices.UserStatusControl(person.PersonID);

            if (username == string.Empty)
            {
                MessageBox.Show("!! Please Enter Username (E-Mail Adress) !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (control == false)
            {
                MessageBox.Show("!! Your Account Have Been Banned", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (person != null)
            {
                string password = txt_Password.Text;

                if (person.Password == password)
                {
                    MessageBox.Show("Login Successfull", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (person.UserType is UserType.User)
                    {

                        MdiForm mdiForm = new MdiForm(person.PersonID);

                        this.Hide();
                        mdiForm.ShowDialog();

                        this.Show();

                    }
                    else
                    {
                        Admin admin = new Admin();

                        this.Hide();

                        admin.ShowDialog();

                        this.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Password is Incorrect !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                DialogResult result = MessageBox.Show("Please Check Your UserName!!!\nIf You Are Not A Member Please Press Yes To SignUp", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    this.Hide();

                    LogOnScreen logOnScreen = new LogOnScreen();
                    logOnScreen.ShowDialog();

                    this.Show();

                }

            }

        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

            LogOnScreen logOnScreen = new LogOnScreen();

            this.Hide();

            logOnScreen.ShowDialog();

            this.Show();
        }



    }
}
