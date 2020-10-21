﻿using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace SportStitch.WebMVC.Models.TeamModels
{
    public class TeamDetail
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        
        [Display(Name ="Roster")]
        public List<SportStitch.Data.Tables.Player> PlayersOnTeam { get; set; }
        public List<Coach> Coaches { get; set; }

        //Sport
        public string SportName { get; set; }

        //Sport->League
        public string LeagueName { get; set; }
        public string City { get; set; }
        public State State { get; set; }

    }
}