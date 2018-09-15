using DataAccessLayer.Models;
using Franking.Models;
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
                new User{Id = 1, Name = "Marcin Karpiesiuk", Email = "marcinkarpiesiuk@gmail.com"},
                new User{Id = 2, Name = "Jan Paweł", Email = "jebandziecian@vatican.com"},
                new User{Id = 3, Name = "Arnold Schwarzeneger", Email = "alekurwapompa@sila.com"},
                new User{Id = 4, Name = "Narco Marco", Email = "elcowboyolacocaina@gmail.com" }
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

            var teams = new List<Team>
            {
                new Team{Id = 1, Name = "Real Madryt", RankID = 10},
                new Team{Id = 2, Name = "Liverpool FC", RankID = 9},
                new Team{Id = 3, Name = "Benfica", RankID = 8},
                new Team{Id = 4, Name = "Legia Warszawa", RankID = 7},
                new Team{Id = 5, Name = "Arsienał Tuła", RankID = 6},
                new Team{Id = 6, Name = "Carpi", RankID = 5},
                new Team{Id = 7, Name = "Shimizu", RankID = 4},
                new Team{Id = 8, Name = "Dundalk", RankID = 3},
                new Team{Id = 9, Name = "Cork City", RankID = 2},
                new Team{Id = 10, Name = "Sogndal", RankID = 1}
            };

            var matches = new List<Match>
            {
                new Match{Id = 1, Home = new Side{PlayerId = 1, TeamId = 1, Score = 3}, Away = new Side{PlayerId = 2, TeamId = 2, Score = 2} },
                new Match{Id = 2, Home = new Side{PlayerId = 3, TeamId = 3, Score = 2}, Away = new Side{PlayerId = 4, TeamId = 4, Score = 3} } 
            };
        }
    }
}
