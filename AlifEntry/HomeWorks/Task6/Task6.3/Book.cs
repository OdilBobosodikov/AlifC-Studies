using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task6.Task6._3
{
    public class Book
    {
        public string Title { get; private set; }
        public string Genre { get; private set; }
        public int Pages { get; private set; }

        public Book(string title, string genre, int pages)
        {
            Title = title;
            Genre = genre;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"Title: {Title}, Genre: {Genre}, Pages: {Pages}";
        }
    }
}
