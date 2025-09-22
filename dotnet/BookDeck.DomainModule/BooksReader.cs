using Dapper;
using Microsoft.Data.SqlClient;

namespace BookDeck.DomainModule;

public record Book(string Title, string Author, string Publisher, DateTime PublishDate, string Edition, string Isbn);

public class BooksReader(ConnectionStrings connectionStrings)
{
    public IEnumerable<Book> GetBooks()
    {
        var conn = new SqlConnection(connectionStrings.BookDeckSqlServer);
        var sql =  """SELECT * FROM Books""";
        return conn.Query<Book>(sql);
    } 
}

public class ConnectionStrings
{
    public string BookDeckSqlServer { get; set; } = string.Empty;
}