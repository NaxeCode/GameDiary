using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameDiaryProj.Models;

namespace GameDiaryProj.Data
{
    public class GameDiaryContext : DbContext
    {
        public GameDiaryContext (DbContextOptions<GameDiaryContext> options)
            : base(options)
        {
        }

        public DbSet<GameDiaryProj.Models.Game> Game { get; set; } = default!;
    }
}
