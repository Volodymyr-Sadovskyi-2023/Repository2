using MyGameApp.Models;
using System.Collections.Generic;

namespace MyGameApp.Data
{
    public static class DataInitializer
    {
        public static List<Genre> Genres = new List<Genre>
        {
            new Genre { Name = "Action", Description = "Fast-paced games with a lot of movement and physical activities." },
            new Genre { Name = "Adventure", Description = "Games that involve exploring and puzzle-solving." },
            new Genre { Name = "RPG", Description = "Role-playing games with character development and story elements." },
            new Genre { Name = "Strategy", Description = "Games that require careful planning and tactical thinking." },
            new Genre { Name = "Simulation", Description = "Games that simulate real-world activities." }
        };

        public static List<Game> Games = new List<Game>
        {
            new Game { Id = 1, Name = "Game1", Price = 29.99m, Category = "Action", Genres = new List<Genre> { Genres[0], Genres[2] } },
            new Game { Id = 2, Name = "Game2", Price = 19.99m, Category = "Adventure", Genres = new List<Genre> { Genres[1] } },
            new Game { Id = 3, Name = "Game3", Price = 39.99m, Category = "RPG", Genres = new List<Genre> { Genres[2] } },
            new Game { Id = 4, Name = "Game4", Price = 49.99m, Category = "Strategy", Genres = new List<Genre> { Genres[3] } },
            new Game { Id = 5, Name = "Game5", Price = 59.99m, Category = "Simulation", Genres = new List<Genre> { Genres[4] } },
            new Game { Id = 6, Name = "Game6", Price = 24.99m, Category = "Action", Genres = new List<Genre> { Genres[0] } },
            new Game { Id = 7, Name = "Game7", Price = 34.99m, Category = "Adventure", Genres = new List<Genre> { Genres[1], Genres[2] } },
            new Game { Id = 8, Name = "Game8", Price = 44.99m, Category = "RPG", Genres = new List<Genre> { Genres[2], Genres[3] } },
            new Game { Id = 9, Name = "Game9", Price = 54.99m, Category = "Strategy", Genres = new List<Genre> { Genres[3], Genres[4] } },
            new Game { Id = 10, Name = "Game10", Price = 64.99m, Category = "Simulation", Genres = new List<Genre> { Genres[4], Genres[0] } }
        };
    }
}