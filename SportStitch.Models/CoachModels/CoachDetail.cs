using Microsoft.AspNet.Identity;
using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportStitchModels.CoachModels
{
    public class CoachDetail
    {
        //Coach properties
        public int CoachID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //League Info
        public string LeagueName { get; set; }
        public string City { get; set; }
        public State State { get; set; }

        //Team Info
        public string TeamName { get; set; }

        [Display(Name = "Roster")]
        public List<SportStitch.Data.Tables.Player> PlayersOnTeam { get; set; }
        public string SportName { get; set; }
       

        //User
        public string OwnerID { get; set; }

    }
}