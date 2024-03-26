using CalorieProject_Models.Concretes;
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
    public partial class MdiForm : Form
    {
        public MdiForm(int personID)
        {
            InitializeComponent();
            this.personID = personID;
        }
        int personID;



        public void CloseChildForms()
        {

            Form[] chieldForms = this.MdiChildren;

            foreach (Form form in chieldForms)
            {
                form.Close();
            }
        }

        private void MdiForm_Load_1(object sender, EventArgs e)
        {
            CloseChildForms();

            OgundenYemekSec ogundenYemekSec = new OgundenYemekSec(personID);

            ogundenYemekSec.MdiParent = this;
            ogundenYemekSec.Dock = DockStyle.Fill;

            this.Width = ogundenYemekSec.Width + 150;
            this.Height = ogundenYemekSec.Height + 150;

            ogundenYemekSec.Show();
        }

        private void addFoodToSystemToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddingFoodScreen addingFoodScreen = new AddingFoodScreen();

            addingFoodScreen.MdiParent = this;
            addingFoodScreen.Dock = DockStyle.Fill;

            this.Height = addingFoodScreen.Height + 50;
            this.Width = addingFoodScreen.Width + 50;

            addingFoodScreen.Show();
        }

        private void chooseMealToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseChildForms();

            OgundenYemekSec ogundenYemekSec = new OgundenYemekSec(personID);

            ogundenYemekSec.MdiParent = this;
            ogundenYemekSec.Dock = DockStyle.Fill;

            this.Width = ogundenYemekSec.Width + 150;
            this.Height = ogundenYemekSec.Height + 150;

            ogundenYemekSec.Show();
        }

        private void myMealHistoryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CloseChildForms();

            MyMealHistory myMealHistory = new MyMealHistory(personID);

            myMealHistory.MdiParent = this;
            myMealHistory.Dock = DockStyle.Fill;

            this.Width = myMealHistory.Width + 50;
            this.Height = myMealHistory.Height + 100;


            myMealHistory.Show();
        }
    }
}
