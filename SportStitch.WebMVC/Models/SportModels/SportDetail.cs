using SportStitch.Data.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.WebMVC.Models.SportModels
{
    public class SportDetail
    {
        public string SportName { get; set; }

        //League
        public string LeagueName { get; set; }
        public State State { get; set; }
        public string City { get; set; }
    }
}