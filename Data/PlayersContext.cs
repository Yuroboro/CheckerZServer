using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheckerZ_Server.Models;

public class PlayersContext : DbContext
    {
        public PlayersContext (DbContextOptions<PlayersContext> options)
            : base(options)
    {
    }

    public DbSet<Player> Player { get; set; } = default!;
    public DbSet<Game> Game { get; set; } 
}
