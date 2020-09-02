using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KKZadar.Models;

namespace KKZadar.Data
{
    public class PlayerContext : DbContext
    {
        public PlayerContext (DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<KKZadar.Models.Player> Player { get; set; }
        public DbSet<KKZadar.Models.Manager> Manager { get; set; }
    }
}
