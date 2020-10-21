using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.Player
{
    public class PlayerCreate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        //League
        public int LeagueID { get; set; }

        //Team
        public int TeamID { get; set; }


    }
}