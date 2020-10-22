using SportStitch.Data.Tables;
using SportStitch.Models.LeagueModels;
using SportStitch.WebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Services
{
    public class LeagueService
    {
        public LeagueService() { }
        public bool CreateLeague(LeagueCreate model)
        {
            var entity =
                new League()
                {
                    LeagueName = model.LeagueName,
                    City = model.City,
                    State = model.State,


                };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Leagues.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get All Leagues
        public IEnumerable<LeagueListItem> GetAllLeagues()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Leagues
                    .Where(e => e.LeagueId == e.LeagueId)
                    .Select(
                        e =>
                        new LeagueListItem
                        {
                            LeagueId = e.LeagueId,
                            LeagueName = e.LeagueName,
                            City = e.City,
                            State = e.State
                        });
                return query.ToArray();
            }
        }

        //Get League by ID
        public LeagueDetail GetLeagueByID(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Leagues
                    .Single(e => e.LeagueId == id);
                    return
                        new LeagueDetail
                        {
                            LeagueName = entity.LeagueName,
                            City = entity.City,
                            State = entity.State,
                            PlayersInLeague = entity.PlayersInLeague.ToList(),
                            SportsInLeague = entity.SportsInLeague.ToList()
                        };
            }
        }

        //Get League by LeagueName
        public LeagueDetail GetLeagueByName(string leagueName)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Leagues
                    .Single(e => e.LeagueName == leagueName);
                return
                    new LeagueDetail
                    {
                        LeagueName = entity.LeagueName,
                        City = entity.City,
                        State = entity.State,
                        PlayersInLeague = entity.PlayersInLeague.ToList(),
                        SportsInLeague = entity.SportsInLeague.ToList()
                    };
            }
        }

        //Update League
        public bool UpdateLeague(LeagueEdit model, int id)
        {
            using(var ctx = new ApplicationDbContext())
            {

            var entity =
                    ctx.Leagues
                    .Single(e => e.LeagueId == id);
                entity.LeagueName = model.LeagueName;
                entity.City = model.City;
                entity.State = model.State;

                return ctx.SaveChanges() == +1;
            }
        }

        //Delete League
        public bool DeleteLeague(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Leagues
                    .Single(e => e.LeagueId == id);
                ctx.Leagues.Remove(entity);
                return ctx.SaveChanges() == +1;
            }
        }
    }
}
