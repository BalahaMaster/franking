using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Franking.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public int HomePlayerID { get; set; }
        public int AwayPlayerID { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }
}
