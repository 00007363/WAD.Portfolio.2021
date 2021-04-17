using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Models
{
    public class Couch
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MinLength(2)]
        public string Nationality { get; set; }
        [Required]
        [MinLength(2)]
        public string CurrentClub { get; set; }
    }
}
