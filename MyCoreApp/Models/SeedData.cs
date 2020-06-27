using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using MyCoreApp.Data;




namespace MyCoreApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyCoreAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyCoreAppContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Star Wars : Episode IV A new hope",
                        ReleaseDate = DateTime.Parse("1977-10-19"),
                        Genre = "Fiction Movie",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Star Wars : Episode V The Empire Strikes Back ",
                        ReleaseDate = DateTime.Parse("1980-8-20"),
                        Genre = "Fiction Movie",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Star Wars: Episode VI Return of the Jedi",
                        ReleaseDate = DateTime.Parse("1983-10-19"),
                        Genre = "Fiction Movie",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Harry Potter and the Deathly Hallows",
                        ReleaseDate = DateTime.Parse("2011-7-15"),
                        Genre = "Fantasy Movie",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}