using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Side
    {
        // class created for clarity of Match class
        public User Player { get; set; }
        public Team Team { get; set; }
        public int Score { get; set; }
    }
}
