using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    class RankingInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<RankingContext>
    {
        protected override void Seed(RankingContext context)
        {
            var users = new List<User>
            {
                new User{Name = "Marcin Karpiesiuk", Email = "marcinkarpiesiuk@gmail.com", IsAdmin = True},
                new User{Name = "Jan Paweł", Email = "jebandziecian@vatican.com"},
                new User{Name = "Arnold Schwarzeneger", Email = "alekurwapompa@sila.com"},
                new User{Name = "Narco Marco", Email = "elcowboyolacocaina@gmail.com" }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var teamRanks = new List<TeamRank>
            {
                new TeamRank{Id = 1, Rank = "Half Star", Value = 0.5},
                new TeamRank{Id = 2, Rank = "One Star", Value = 1.0},
                new TeamRank{Id = 3, Rank = "One And A Half Star", Value = 1.5},
                new TeamRank{Id = 4, Rank = "Two Stars", Value = 2.0},
                new TeamRank{Id = 5, Rank = "Two And A Half Star", Value = 2.5},
                new TeamRank{Id = 6, Rank = "Three Stars", Value = 3.0},
                new TeamRank{Id = 7, Rank = "Three And A Half Star", Value = 3.5},
                new TeamRank{Id = 8, Rank = "Four Stars", Value = 4.0},
                new TeamRank{Id = 9, Rank = "Four And A Half Star", Value = 4.5},
                new TeamRank{Id = 10, Rank = "Five Stars", Value = 5.0}
            };

            var team = new List<Team>
            {
                new Team{Name = "Real Madryt", RankID = 10},
                new Team{Name = "Liverpool FC", RankID = 9},
                new Team{Name = "Benfica", RankID = 8},
                new Team{Name = "Legia Warszawa", RankID = 7},
                new Team{Name = "Arsienał Tuła", RankID = 6},
                new Team{Name = "Carpi", RankID = 5},
                new Team{Name = "Shimizu", RankID = 4},
                new Team{Name = "Dundalk", RankID = 3},
                new Team{Name = "Cork City", RankID = 2},
                new Team{Name = "Sogndal", RankID = 1}
            };
        }
    }
}
