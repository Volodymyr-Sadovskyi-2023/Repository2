using System;
using MyGameApp.Services;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var gameService = new GameService();

        var game = gameService.GetGameById(1);
        Console.WriteLine($"Game by Id 1: {game.Name}");

        var gamesInRange = gameService.GetGamesInPriceRange(20, 50);
        Console.WriteLine($"Games in price range 20-50: {string.Join(", ", gamesInRange.Select(g => g.Name))}");

        var genresByGame = gameService.GetGenresByGame(1);
        Console.WriteLine($"Genres by game Id 1: {string.Join(", ", genresByGame.Select(g => g.Name))}");

        var uniqueCategories = gameService.GetUniqueCategories();
        Console.WriteLine($"Unique categories: {string.Join(", ", uniqueCategories)}");

        var filteredGames = gameService.FilterGamesByCategoryAndGenres("Action", new List<string> { "Action", "RPG" });
        Console.WriteLine($"Filtered games by category 'Action' and genres 'Action' or 'RPG': {string.Join(", ", filteredGames.Select(g => g.Name))}");

        var paginatedGames = gameService.GetGamesWithPagination(1);
        Console.WriteLine($"Games on page 1: {string.Join(", ", paginatedGames.Select(g => g.Name))}");
    }
}