using LinqProject;

LinqQueries linqQueries = new LinqQueries();

var allBooks = linqQueries.GetAllBooks();

var booksAfter2000 = linqQueries.BooksAfter2000();

var booksQuery2 = linqQueries.BooksQuery2();

Console.WriteLine($"All Books Has Status? - {linqQueries.AllBooksHasStatus()}");

Console.WriteLine("=================================");

Console.WriteLine($"Was any book published in 2005? - {linqQueries.AnyPublish2005()}");

Console.WriteLine("=================================");

ImprimirValores(booksQuery2);

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}