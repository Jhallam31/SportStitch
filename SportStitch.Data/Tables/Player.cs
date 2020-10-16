using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Data.Tables
{
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        
        [Required]
        //Creates connection between the Application user and the Player Table
        public string OwnerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int Age {  set {Age = Convert.ToInt32(DateTime.Now - DateOfBirth); } }
       
        //Navigation property to Specified League
        [ForeignKey(nameof(League))]
        public int LeagueID { get; set; }
        public virtual League League { get; set; }

    }
}
