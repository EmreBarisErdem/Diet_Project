using CalorieProject_BLL.Services;
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
    }
}
