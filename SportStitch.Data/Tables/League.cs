using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Data.Tables
{
    public enum State {
        AK, AL, AR,AZ,CA,CO,CT,DE,FL,GA,HI,IA,ID,IL,IN,KS,KY,LA,MA,MD,ME,MI,MN,MO,MS,MT,NC,ND,NE,NH,NJ,NM,NV,NY,OH,OK,OR,PA,RI,SC,SD,TN,TX,UT,VA,VT,WA,WI,WV,WY
    }
    public class League
    {
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
        public string City { get; set; }
        public State  State { get; set; }
        public ICollection<Sport> SportsInLeague { get; set; }
        public ICollection<Player> PlayersInLeague { get; set; }


    }
}
