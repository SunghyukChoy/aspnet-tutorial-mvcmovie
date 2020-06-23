using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {

                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1999-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1994-3-14"),
                        Genre = "Action",
                        Price = 6.55M
                    },

                    new Movie
                    {
                        Title = "Oblivion",
                        ReleaseDate = DateTime.Parse("2016-05-04"),
                        Genre = "SF",
                        Price = 9.00M
                    },

                    new Movie
                    {
                        Title = "Rio",
                        ReleaseDate = DateTime.Parse("2017-03-20"),
                        Genre = "Animation",
                        Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
