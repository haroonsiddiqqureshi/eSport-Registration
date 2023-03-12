using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSport_Registration
{
    internal class Team
    {
        [DisplayName("Team Name")]
        public string Teamname { get; set; }
        [DisplayName("1st Player")]
        public string Name1 { get; set; }
        [DisplayName("1st Username")]
        public string Username1 { get; set; }
        [DisplayName("2nd Player")]
        public string Name2 { get; set; }
        [DisplayName("2nd Username")]
        public string Username2 { get; set; }
        [DisplayName("3rd Player")]
        public string Name3 { get; set; }
        [DisplayName("3rd Username")]
        public string Username3 { get; set; }
        [DisplayName("4th Player")]
        public string Name4 { get; set; }
        [DisplayName("4th Username")]
        public string Username4 { get; set; }
        [DisplayName("5th Player")]
        public string Name5 { get; set; }
        [DisplayName("5th Username")]
        public string Username5 { get; set; }

        public Team(string teamName, string name1, string username1, string name2, string username2, string name3, string username3, string name4, string username4, string name5, string username5) 
        {
            this.Teamname = teamName;
            this.Name1 = name1;
            this.Username1 = username1;
            this.Name2 = name2; 
            this.Username2 = username2;
            this.Name3 = name3;
            this.Username3 = username3;
            this.Name4 = name4;
            this.Username4 = username4;
            this.Name5 = name5;
            this.Username5 = username5;
        }
    }
}
