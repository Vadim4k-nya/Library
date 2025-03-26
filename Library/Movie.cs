using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Movie : Media
    {
        public int _duration;
        public string _director;

        public Movie(string title, string author, int yearPublished, bool isAvailable, int duration, string director)
            : base(title, author, yearPublished, isAvailable)
        {
            _duration = duration;
            _director = director;
        }
    }
}
