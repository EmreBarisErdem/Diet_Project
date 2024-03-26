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
    public partial class Reklam : Form
    {
        public Reklam()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogInScreen loginScreen = new LogInScreen();

            this.Hide();

            loginScreen.ShowDialog();

            this.Show();
        }

    }
}
