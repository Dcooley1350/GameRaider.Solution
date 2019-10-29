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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Game>()
                .HasData(
                    new Game { GameId = 1, Raiding = 5, Title = "Skyrim", Studio = "Bethesda", ReleaseDate = "2011" },
                    new Game { GameId = 2, Raiding = 5, Title = "Red Dead Redemtion 2", Studio = "Rockstar", ReleaseDate = "2018" },
                    new Game { GameId = 3, Raiding = 2, Title = "Wolfenstein Youngblood", Studio = "id Software", ReleaseDate = "2019" },
                    new Game { GameId = 4, Raiding = 4, Title = "Bloodborne", Studio = "FromSoftware", ReleaseDate = "2015" },
                    new Game { GameId = 5, Raiding = 3, Title = "Need for Speed Rivals", Studio = "Ghost Games", ReleaseDate = "2013" },
                    new Game { GameId = 6, Raiding = 1, Title = "Mario Sunshine", Studio = "Nintendo", ReleaseDate = "2002" }
                );

            builder.Entity<Review>()
                .HasData(
                    new Review { ReviewId = 1, GameId = 2, ReviewAuthor = "BeffJezos666", ReviewText = "The worlding building in this game is on a whole new level, bro. It is so big, so detailed, and I get to be a cowboy and ride my horse, Whitneigh Horsten, all over town", PublishDate = "October 26, 2019", Raiding = 5},
                    new Review { ReviewId = 2, GameId = 1, ReviewAuthor = "RunDMC123", ReviewText = "It is the incapable younger brother of Morrowind, but nonetheless I played it", PublishDate = "February 26, 2015", Raiding = 2},
                    new Review { ReviewId = 3, GameId = 3, ReviewAuthor = "TaylorLautner420", ReviewText = "This game sucked bro", PublishDate = "May 1, 2002", Raiding = 2}
                );
        }        
    }
}