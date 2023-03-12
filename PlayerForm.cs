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
    public partial class PlayerForm : Form
    {
        static BindingList<Player> listPLayer = new BindingList<Player>();
        public static string Setname = "";
        public static string Setusername = "";
        public int setIndex;
        public PlayerForm()
        {
            InitializeComponent();
            this.dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.DataSource= listPLayer;
            this.AddPlayer.Enabled=false;
        }

        private void SelectPlayer(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString();
                string username = row.Cells[1].Value.ToString();
                this.Name.Text = name;
                this.Username.Text = username;
                Setname = name;
                Setusername = username;
                setIndex = e.RowIndex;
            }
            this.AddPlayer.Enabled= true;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayerForm= new AddPlayerForm();
            addPlayerForm.ShowDialog();

            if (addPlayerForm.DialogResult == DialogResult.OK) 
            {
                string name = AddPlayerForm.Setname;
                string username = AddPlayerForm.Setusername;

                Player newPlayer = new Player(name, username);
                listPLayer.Add(newPlayer);
                this.dataGridView1.DataSource= listPLayer;
                this.dataGridView1.Columns[0].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            listPLayer.RemoveAt(setIndex);
            this.DialogResult= DialogResult.OK;
        }
    }
}
