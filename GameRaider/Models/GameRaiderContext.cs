using Microsoft.EntityFrameworkCore;

namespace GameRaider.Models
{
    public class GameRaiderContext : DbContext
    {
        public GameRaiderContext(DbContextOptions<GameRaiderContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}