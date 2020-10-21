using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.Player
{
    public class PlayerDetail
    {

        
        public int PlayerID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }

        //League 
        public string LeagueName { get; set; }
        public State State { get; set; }
        public string City { get; set; }

        //Team
        public string TeamName { get; set; }
        public List<Coach> Coaches { get; set; }

        //Team->Sport
        public string SportName { get; set; }
    }
}