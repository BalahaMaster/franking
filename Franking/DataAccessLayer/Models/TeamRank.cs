using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class TeamRank
    {
        public int Id { get; set; }
        public string Rank { get; set; }
        public double Value { get; set; }

        //public static readonly TeamRank HALF_STAR = new TeamRank(0.5);
        //public static readonly TeamRank ONE_STAR = new TeamRank(1);
        //public static readonly TeamRank ONE_HALF_STAR = new TeamRank(1.5);
        //public static readonly TeamRank TWO_STAR = new TeamRank(2);
        //public static readonly TeamRank TWO_HALF_STAR = new TeamRank(2.5);
        //public static readonly TeamRank THREE_STAR = new TeamRank(3);
        //public static readonly TeamRank THREE_HALF_STAR = new TeamRank(3.5);
        //public static readonly TeamRank FOUR_STAR = new TeamRank(4);
        //public static readonly TeamRank FOUR_HALF_STAR = new TeamRank(4.5);
        //public static readonly TeamRank FIVE_STAR = new TeamRank(5);

        //public TeamRank(double valueParam)
        //{
        //    this.Value = valueParam;
        //}
    }
}
