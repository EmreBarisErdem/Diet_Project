﻿using System;
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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

 
        private void button1_Click_1(object sender, EventArgs e)
        {
            Reklam reklam = new Reklam();

            this.Hide();

            reklam.ShowDialog();

            this.Show();
        }
    }
}
