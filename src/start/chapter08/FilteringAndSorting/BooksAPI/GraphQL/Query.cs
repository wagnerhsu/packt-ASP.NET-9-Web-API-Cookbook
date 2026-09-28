using Books.Models;
using Books.Services;

namespace Books.GraphQL;

public class Query
{
    public IQueryable<BookDTO> GetBooks([Service] IBooksService booksService) {
        return booksService.GetBooks();
    }
} 
