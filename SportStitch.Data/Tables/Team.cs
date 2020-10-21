using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Data.Tables
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public ICollection<Player> PlayersOnTeam { get; set; }
        public ICollection<Coach> CoachesForTeam { get; set; }
        public int PlayerCount { 
            get 
            { 
                return PlayersOnTeam.Count(); 
            } 
        }


        [ForeignKey(nameof(Sport))]
        public int SportID { get; set; }
        public virtual Sport TeamSport { get; set; }


    }
}
