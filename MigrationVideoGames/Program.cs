

using Microsoft.EntityFrameworkCore;

class MainClass
{

    static void Main()
    {
        using (var context = new VideoGamesContext.VideoGamesContext())
        {
            var games = context.Games
                .Include(g => g.Studio)
                .Include(g => g.Genre)
                .ToList();
            foreach (var game in games)
            {
                Console.WriteLine($"Title: {game.Title}");
                Console.WriteLine($"Studio: {game.Studio.Name}");
                Console.WriteLine($"Genre: {game.Genre.Name}");
                Console.WriteLine($"Release Date: {game.ReleaseDate}");
                Console.WriteLine($"Is Single: {(game.IsSingle.HasValue ? game.IsSingle.Value.ToString() : "N/A")}");
                Console.WriteLine($"Copies Sold: {(game.CopiesSold.HasValue ? game.CopiesSold.Value.ToString() : "N/A")}");
                Console.WriteLine();
            }
        }

    }



}