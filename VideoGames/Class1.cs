namespace VideoGames
{
    public class Game
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public int StudioId { get; set; } 
        public GameStudio Studio { get; set; }
        public int GenreId { get; set; }
        public GameGenre Genre { get; set; } 
        public DateTime ReleaseDate { get; set; } 
    }

    public class GameStudio
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }

    public class GameGenre
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
