using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Models
{
    public class Player
    {
        [Range(0, int.MaxValue)]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Range(16, int.MaxValue)]

        public int Age { get; set; }

        [MinLength(3)]
        public string Origin { get; set; }

        [MinLength(3)]
        public string Position { get; set; }

        [Range(1, 99)]
        public int KitNumber { get; set; }

        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
