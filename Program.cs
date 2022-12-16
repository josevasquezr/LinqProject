using LinqProject;

LinqQueries linqQueries = new LinqQueries();

var allBooks = linqQueries.GetAllBooks();

var booksAfter2000 = linqQueries.BooksAfter2000();

var booksQuery2 = linqQueries.BooksQuery2();

var pythonBooks = linqQueries.BooksQueryWithContains();

var queryOrderBy1 = linqQueries.QueryOrderBy1();

var queryOrderBy2 = linqQueries.QueryOrderBy2();

var queryTake = linqQueries.QueryTake();

var querySkip = linqQueries.QuerySkip();

var querySelect = linqQueries.QuerySelect();


Console.WriteLine($"All Books Has Status? - {linqQueries.AllBooksHasStatus()}");

Console.WriteLine("=================================");

Console.WriteLine($"Was any book published in 2005? - {linqQueries.AnyPublish2005()}");

Console.WriteLine("=================================");

ImprimirValores(querySelect);

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}