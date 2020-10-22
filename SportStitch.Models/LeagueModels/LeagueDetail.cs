using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.Models.LeagueModels
{
    public class LeagueDetail
    {
        public string LeagueName { get; set; }
        public string City { get; set; }
        public State State { get; set; }

        //Players
        public List<Player> PlayersInLeague { get; set; }

        //Sports
        public List<Sport> SportsInLeague { get; set; }

    }
}