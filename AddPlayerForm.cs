﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eSport_Registration
{
    public partial class AddPlayerForm : Form
    {
        public static string Setname = "";
        public static string Setusername = "";
        public AddPlayerForm()
        {
            InitializeComponent();
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            Setname = this.textBox1.Text;
            Setusername = this.textBox2.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
