using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSport_Registration
{
    internal class Player
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        public Player(string name, string username)
        {
            Name = name;
            Username = username;
        }
    }
}
