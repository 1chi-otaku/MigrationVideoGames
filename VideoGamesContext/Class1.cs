using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VideoGames;


namespace VideoGamesContext
{
    public class VideoGamesContext : DbContext
    {
        public VideoGamesContext()
        {
            
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<GameStudio> GameStudios { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=PECHKA\SQLEXPRESS;Database=VideoGames;Integrated Security=SSPI;TrustServerCertificate=true");
        }
    }
}
