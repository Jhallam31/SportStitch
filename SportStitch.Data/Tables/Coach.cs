using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Data.Tables
{
    public class Coach
    {
        [Key]
        public int CoachID { get; set; }

        [Required]
        //Creates connection between the Application user and the Player Table
        public string OwnerID { get; set; }
        
        [Required]
        public string FirstName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [ForeignKey(nameof(League))]
        //Navigation property to League this Coach is associated with
        public int LeagueID { get; set; }
        public virtual League League { get; set; }

        [ForeignKey(nameof(Team))]
        //Navigation property to the team this coach is assigned to
        public int TeamID { get; set; }
        public virtual Team Team { get; set; }


    }
}
