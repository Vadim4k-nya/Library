using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class MusicAlbum : Media
    {
        public string _artist;
        public int _trackCount;

        public MusicAlbum(string title, string author, int yearPublished, bool isAvailable, string artist, int trackCount)
            : base(title, author, yearPublished, isAvailable)
        {
            _artist = artist;
            _trackCount = trackCount;
        }
    }
}
