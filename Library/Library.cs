using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library<T> : IMediaManager<T> where T : Media
    {
        public List<T> _list = new List<T>();
        public Dictionary<string, T> _dict = new Dictionary<string, T>();

        public void Add(T item) 
        {
            try
            {
                _list.Add(item);
                _dict[item._title] = item;
                Console.WriteLine($"Объект {item._title} добавлен");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Remove(string title) 
        {
            try
            {
                T removedItem = _dict[title];
                _list.Remove(removedItem);
                _dict.Remove(title);
                Console.WriteLine($"Объект {title} удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public T FindByTitle(string title)
        {
            try
            {
                return _dict[title];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        //отфильтровать по году
        public IEnumerable<T> FilterByYear(int year)
        {
            return _list.Where(item => item._yearPublished == year);
        }

        //найти все недоступные элементы
        public IEnumerable<T> GetAllAvailable()
        {
            return _list.Where(item => item._isAvailable);
        }

        //найти все книги, выпущенные после xxxx года
        public IEnumerable<Book> GetBooksAfterYear(int year)
        {
            return _list.OfType<Book>().Where(book => book._yearPublished > year);
        }

        //получить список фильмов, отсортированных по длительности
        public IEnumerable<Movie> GetMoviesSortedByDuration()
        {
            return _list.OfType<Movie>().OrderBy(movie => movie._duration);
        }

        //найти все недоступные элементы
        public IEnumerable<T> GetAllUnavailable()
        {
            return _list.Where(item => !item._isAvailable);
        }

        public void Print(T item)
        {
            Console.Write($"{item._title}\t| {item._autor}\t| {item._yearPublished}\t| {item._isAvailable}\t| ");
            if (item is Book book)
            {
                Console.WriteLine($"{book._pages}\t\t| {book._genre}");
            }
            else if (item is Movie movie)
            {
                Console.WriteLine($"{movie._duration}m\t\t| {movie._director}");
            }
            else if (item is MusicAlbum album)
            {
                Console.WriteLine($"{album._artist}\t| {album._trackCount}");
            }
        }

        public void SwitchAvalability(T item)
        {
            item._isAvailable = !(item._isAvailable);
        }

        public void PrintAll() 
        {
            foreach (var item in _list)
            {
                Console.Write($"{item._title}\t| {item._autor}\t| {item._yearPublished}\t| {item._isAvailable}\t| ");
                if (item is Book book)
                {
                    Console.WriteLine($"{book._pages}\t\t| {book._genre}");
                }
                else if (item is Movie movie)
                {
                    Console.WriteLine($"{movie._duration}m\t\t| {movie._director}");
                }
                else if (item is MusicAlbum album)
                {
                    Console.WriteLine($"{album._artist}\t| {album._trackCount}");
                }
            }
        }
    }
}
