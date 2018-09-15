using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Franking.Models
{
    public class Match
    {
        public int Id { get; set; }
        [Required]
        public Side Home { get; set; }
        [Required]
        public Side Away { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime MatchCreated{ get; set; }
        //[Required]
        //public int HomePlayerId { get; set; }
        //[Required]
        //public int HomeTeamId { get; set; }
        //[Required]
        //public int AwayPlayerId { get; set; }
        //[Required]
        //public int AwayTeamId { get; set; }
        //[Required]
        //public int HomeScore { get; set; }
        //[Required]
        //public int AwayScore { get; set; }
    }
}
