using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    [ComplexType]
    public class Side
    {
        // class created for clarity of Match class
        [Required]
        public int PlayerId{ get; set; }
        [Required]
        public int TeamId{ get; set; }
        [Required]
        public int Score { get; set; }
    }
}
