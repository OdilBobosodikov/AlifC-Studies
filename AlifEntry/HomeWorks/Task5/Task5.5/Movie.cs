using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task5.Task5._5
{
    public class Movie
    {
        public string Title { get; private set; } = string.Empty;
        public string Genre { get; private set; } = string.Empty;
        public int Duration { get; private set; }
        public double Rating { get; set; }

        public void SetMovie(string title, string genre, int duration, double rating)
        {
            Title = title.ToLower();
            Genre = genre.ToLower();
            Duration = duration;
            Rating = rating;
        }
    }
}
