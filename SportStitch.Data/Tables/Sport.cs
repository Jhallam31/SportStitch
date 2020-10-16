using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Data.Tables
{
    public class Sport
    {
        [Key]
        public int SportId { get; set; }
        [Required]
        public string SportName { get; set; }

        //Navigation Property to the League specified
        [ForeignKey(nameof(League))]
        public int LeagueID { get; set; }
        public virtual League League { get; set; }
    }
}
