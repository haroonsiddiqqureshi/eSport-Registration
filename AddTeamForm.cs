using System;
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
    public partial class AddTeamForm : Form
    {
        public static string Setname = "";
        public static string Setusername = "";
        public AddTeamForm()
        {
            InitializeComponent();
        }

        private void SelectPlayerButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            PlayerForm playerForm = new PlayerForm();
            playerForm.ShowDialog();

            if (playerForm.DialogResult == DialogResult.OK) 
            {
                string name = PlayerForm.Setname;
                string username = PlayerForm.Setusername;
                if (button.Name == "Add1") 
                {
                    this.player1.Text= name;
                    this.username1.Text = username;
                }
                if (button.Name == "Add2")
                {
                    this.player2.Text = name;
                    this.username2.Text = username;
                }
                if (button.Name == "Add3")
                {
                    this.player3.Text = name;
                    this.username3.Text = username;
                }
                if (button.Name == "Add4")
                {
                    this.player4.Text = name;
                    this.username4.Text = username;
                }
                if (button.Name == "Add5")
                {
                    this.player5.Text = name;
                    this.username5.Text = username;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string team = this.Team.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
