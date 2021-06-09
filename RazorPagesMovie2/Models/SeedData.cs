using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovie2Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovie2Context>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        Date = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R1"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        Date = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R1"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        Date = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "R1"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        Date = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "R1"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
