using SportStitch.Data.Tables;
using SportStitch.Models.SportModels;
using SportStitch.WebMVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStitch.Services
{
    public class SportService
    {
        public SportService() { }
        public bool CreateSport(SportCreate model)
        {
            var entity =
                new Sport()
                {
                    SportName = model.SportName,
                    LeagueID = model.LeagueID

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Sports.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get All Leagues
        public IEnumerable<SportListItem> GetAllSports()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Sports
                    .Where(e => e.SportId == e.SportId)
                    .Select(
                        e =>
                        new SportListItem
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
            using (var ctx = new ApplicationDbContext())
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
            using (var ctx = new ApplicationDbContext())
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
