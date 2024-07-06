using MyGameApp.Models;
using MyGameApp.Data;
using System.Collections.Generic;
using System.Linq;

namespace MyGameApp.Services
{
    public class GameService
    {
        public Game GetGameById(int id)
        {
            return DataInitializer.Games.FirstOrDefault(g => g.Id == id);
        }

        public List<Game> GetGamesInPriceRange(decimal minPrice, decimal maxPrice)
        {
            return DataInitializer.Games.Where(g => g.Price >= minPrice && g.Price <= maxPrice).ToList();
        }

        public IEnumerable<Genre> GetGenresByGame(int gameId)
        {
            var game = DataInitializer.Games.FirstOrDefault(g => g.Id == gameId);
            return game?.Genres ?? Enumerable.Empty<Genre>();
        }

        public IEnumerable<string> GetUniqueCategories()
        {
            return DataInitializer.Games.Select(g => g.Category).Distinct();
        }

        public List<Game> FilterGamesByCategoryAndGenres(string category, List<string> genreNames)
        {
            return DataInitializer.Games
                .Where(g => g.Category == category && g.Genres.Any(genre => genreNames.Contains(genre.Name)))
                .ToList();
        }

        public List<Game> GetGamesWithPagination(int pageNumber, int pageSize = 5)
        {
            return DataInitializer.Games
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
    }
}