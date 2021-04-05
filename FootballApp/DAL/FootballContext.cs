using FootballApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApp
{
    public class FootballContext : DbContext
    {
        public FootballContext(DbContextOptions<FootballContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Club> Club { get; set; }
        public virtual DbSet<Player> Player { get; set; }
    }
}
