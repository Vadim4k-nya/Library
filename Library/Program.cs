namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library<Media> lib = new Library<Media>();

            Book book1 = new Book("Book1", "Author1", 2000, true, 300, "Fiction");
            Book book2 = new Book("Book2", "Author2", 2010, false, 500, "Fantasy");

            Movie movie1 = new Movie("Movie1", "Director1", 2008, true, 120, "Director1");
            Movie movie2 = new Movie("Movie2", "Director2", 2015, true, 90, "Director2");

            MusicAlbum album1 = new MusicAlbum("Album1", "Artist1", 2008, true, "Artist1", 10);
            MusicAlbum album2 = new MusicAlbum("Album2", "Artist2", 2018, false, "Artist2", 12);

            lib.Add(book1);
            lib.Add(book2);
            lib.Add(movie1);
            lib.Add(movie2);
            lib.Add(album1);
            lib.Add(album2);

            Console.WriteLine("\n");

            lib.Print(lib.FindByTitle("Book1"));

            Console.WriteLine("\n");
            Console.WriteLine("Книги, выпущенные в 2008 году:");
            foreach (var item in lib.FilterByYear(2008))
            {
                lib.Print(item);
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nДоступные элементы:");
            foreach (var item in lib.GetAllAvailable())
            {
                lib.Print(item);
            }

            Console.WriteLine("\n");

            //lib.Remove("Book2");
            
            Console.WriteLine("\n");
            
            Console.WriteLine("Книги, выпущенные после 2005 года:");
            foreach (var item in lib.GetBooksAfterYear(2005))
            {
                lib.Print(item);
            }

            
            Console.WriteLine("\nФильмы, отсортированные по длительности:");
            foreach (var item in lib.GetMoviesSortedByDuration())
            {
                lib.Print(item);
            }

            
            Console.WriteLine("\nНедоступные элементы:");
            foreach (var item in lib.GetAllUnavailable())
            {
                lib.Print(item);
            }

            Console.WriteLine("\n\nВсе элементы:");

            lib.PrintAll();

        }
    }
}
