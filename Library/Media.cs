using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Media
    {
        public string _title;
        public string _autor;
        public int _yearPublished;
        public bool _isAvailable;

        public Media(string title, string author, int yearPublished, bool isAvailable)
        {
            _title = title;
            _autor = author;
            _yearPublished = yearPublished;
            _isAvailable = isAvailable;
        }
    }
}
