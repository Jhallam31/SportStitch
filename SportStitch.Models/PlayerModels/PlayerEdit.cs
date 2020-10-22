using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStitch.Models.PlayerModels
{
    public class PlayerEdit
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; }
    }
}