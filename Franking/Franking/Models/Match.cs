using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Franking.Models
{
    public class Match
    {
        public Side Home { get; set; }
        public Side Away { get; set; }
        public Side Winner
        {
            get { return Winner; }
            set
            {
                if (Home.Score == Away.Score) Winner = null;
                else if (Home.Score > Away.Score) Winner = Home;
                else
                    Winner = Away;
                    
            }
        }

        public Match(Side homeParam, Side awayParam)
        {
            this.Home = homeParam;
            this.Away = awayParam;
        }
    }
}
