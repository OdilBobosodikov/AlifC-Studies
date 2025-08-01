using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.HomeWorks.Task6.Task6._3
{
    public class Author
    {
        private string _name;
        private int _age;
        private string _nationality;
        private List<Book> _books;

        public Author()
        {
            _name = "undefined";
            _age = 0;
            _nationality = "undefined";
            _books = new List<Book>();
        }

        public Author(string name, int age)
        {
            _name = name;
            _age = age;
            _nationality = "undefined";
            _books = new List<Book>();
        }

        public Author(string name, int age, string nationality)
        {
            _name = name;
            _age = age;
            _nationality = nationality;
            _books = new List<Book>();
        }

        public string GetName() => _name;
        public int GetAge() => _age;
        public string GetNationality() => _nationality;

        public void Introduce()
        {
            Console.WriteLine($"Name: {_name}| Age: {_age}| Nationality: {_nationality}");
        }

        public void CelebrateBirthday()
        {
            _age++;
        }

        public void AddBook(Book book)
        {
            var possibleDublicate = _books.FirstOrDefault(x => x.Title == book.Title);

            if (possibleDublicate != null) 
            {
                Console.WriteLine("We already have that book");
                return;
            }
            _books.Add(book);
        }

        public List<Book> ListBooks()
        {
            return _books;
        }
    }
}

