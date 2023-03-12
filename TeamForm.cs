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
    public partial class TeamForm : Form
    {
        BindingList<Team> TeamList = new BindingList<Team>();
        public TeamForm()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = TeamList;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.toolStripDropDownButton2.HideDropDown();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.toolStripDropDownButton1.HideDropDown();
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeamForm= new AddTeamForm();
            addTeamForm.ShowDialog();

            if (addTeamForm.DialogResult == DialogResult.OK)
            {
                string team = addTeamForm.Team.Text;

                string name1 = addTeamForm.player1.Text;
                string username1 = addTeamForm.username1.Text;

                string name2 = addTeamForm.player2.Text;
                string username2 = addTeamForm.username2.Text;

                string name3 = addTeamForm.player3.Text;
                string username3 = addTeamForm.username3.Text;

                string name4 = addTeamForm.player4.Text;
                string username4 = addTeamForm.username4.Text;

                string name5 = addTeamForm.player5.Text;
                string username5 = addTeamForm.username5.Text;

                Team newTeam = new Team(team, name1, username1, name2, username2, name3, username3, name4, username4, name5, username5);
                TeamList.Add(newTeam);

                this.dataGridView1.DataSource=TeamList;
            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Team item in TeamList)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item.Teamname,
                            item.Name1,
                            item.Username1,
                            item.Name2,
                            item.Username2,
                            item.Name3,
                            item.Username3,
                            item.Name4,
                            item.Username4,
                            item.Name5,
                            item.Username5
                            ));
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 11)
                        {
                            Team teams = new Team(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                line[4],
                                line[5],
                                line[6],
                                line[7],
                                line[8],
                                line[9],
                                line[10]
                            );
                            TeamList.Add(teams);
                        }
                    }
                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = TeamList;
            }
        }
    }
}
