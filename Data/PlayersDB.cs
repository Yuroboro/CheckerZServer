using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CheckerZ_Server;

    public class PlayersDB : DbContext
    {
        public PlayersDB (DbContextOptions<PlayersDB> options)
            : base(options)
        {
        }

        public DbSet<CheckerZ_Server.Player> Player { get; set; } = default!;
    }
