using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._5
{
    public class User
    {
        public string? Name { get; private set; }
        public List<Movie> WatchedMovies { get; private set; } = new();

        public User(string name)
        {
            Name = name;
        }

        public void WatchMovie(Movie movie)
        {
            if (string.IsNullOrEmpty(movie.Title))
            {
                Console.WriteLine("Title cant be empty");
                return;
            }
            WatchedMovies.ForEach((x) =>
            {
                if (x.Title.Equals(movie.Title.ToLower()))
                {
                    Console.WriteLine("Movie was already watched");
                    return;
                }
            });

            WatchedMovies.Add(movie);
        }

        public List<Movie> GetWatchHistory()
        {
            return WatchedMovies;
        }

        public void RateMovie(Movie movie, double rating)
        {
            if (rating < 0 && rating > 10) 
            {
                Console.WriteLine("Wrong rating input");
                return;
            }

            var watchedMovie = WatchedMovies.FirstOrDefault(x => x.Title.Equals(movie.Title.ToLower()));

            if (watchedMovie == null) 
            {
                Console.WriteLine("You cant rate movie that you did not watch!");
                return;
            }

            watchedMovie.Rating = rating;
        }

        public List<Movie>? RecomendedByGenre(string genre) 
        {
            return WatchedMovies.Where(x => x.Genre == genre.ToLower()).ToList();
        }

        public double GetAverageRating() 
        {
            return WatchedMovies.Select(x => x.Rating).Sum() / WatchedMovies.Count();
        }
    }
}
