using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.Player
{
    public class PlayerListItem
    {
        public int PlayerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string LeagueName { get; set; }

        //Team.TeamSport.SportName
        public string SportName { get; set; }
        //Team.TeamName
        public string TeamName { get; set; }
    }
}