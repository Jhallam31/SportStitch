using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.CoachModels
{
    public class CoachCreate
    {
        //references the associated team
        public int TeamID { get; set; }

        //references the associated league
        public int LeagueID { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}