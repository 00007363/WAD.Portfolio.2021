using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp.Models
{
    public class Club
    {
        [Range(0, int.MaxValue)]
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [MinLength(3)]
        public string HomeCountry { get; set; }

        [MinLength(3)]
        public string Stadium { get; set; }

        [Range(1800, int.MaxValue)]
        public int FoundedYear { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
