using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.Models.TeamModels
{
    public class TeamCreate
    {
        public string TeamName { get; set; }

        //Sport
        public int SportID { get; set; }
    }
}