using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.CoachModels
{
    public class CoachListItem
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //League
        public string LeagueName { get; set; }

        //Team
        public string TeamName { get; set; }


    }
}