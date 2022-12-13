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
    }
}
