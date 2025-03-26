using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : Media
    {
        public int _pages;
        public string _genre;

        public Book(string title, string author, int yearPublished, bool isAvailable, int pageCount, string genre)
            : base(title, author, yearPublished, isAvailable)
        {
            _pages = pageCount;
            _genre = genre;
        }
    }
}
