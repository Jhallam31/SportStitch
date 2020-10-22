using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.Models.TeamModels
{
    public class TeamListItem
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public int PlayerCount { get; set; }
        public List<Coach> Coaches { get; set; }
    }
}