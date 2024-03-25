namespace VideoGames
{
    public class Game
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public int StudioId { get; set; } 
        public virtual GameStudio Studio { get; set; }
        public int GenreId { get; set; }
        public virtual GameGenre Genre { get; set; } 
        public DateTime ReleaseDate { get; set; } 
        public bool? IsSingle {  get; set; }
        public int? CopiesSold {  get; set; }
    }

    public class GameStudio
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }

    public class GameGenre
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
