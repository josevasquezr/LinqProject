using System.Linq;
using System.Reflection;
using System.Text.Json;

namespace LinqProject
{
    public class LinqQueries
    {
        private List<Book> librosCollection = new List<Book>();
        public LinqQueries() 
        {
            using (StreamReader reader = new StreamReader(@"..\..\..\books.json"))
            {
                string json = reader.ReadToEnd();

                this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return librosCollection;
        }

        public IEnumerable<Book> BooksAfter2000()
        {
            return from book in librosCollection
                    where book.PublishedDate.Year > 2000
                    select book;

            //return this.librosCollection.Where( b => b.PublishedDate.Year > 2000);
        }

        public IEnumerable<Book> BooksQuery2()
        {
            return from book in this.librosCollection
                   where book.PageCount > 250 && book.Title.Contains("in Action")
                   select book;

            //return this.librosCollection.Where(book => book.PageCount > 250 && book.Title.Contains("in Action"));
        }

        public bool AllBooksHasStatus()
        {
            return this.librosCollection.All( b => b.Status != String.Empty);
        }

        public bool AnyPublish2005()
        {
            return this.librosCollection.Any(b => b.PublishedDate.Year == 2005);
        }
    }
}
