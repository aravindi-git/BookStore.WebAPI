using BookStore.Models.Models;
using MongoDB.Driver;

namespace BookStore.Data
{
    public interface IDbClient
    {
         IMongoCollection<Book> GetBooksCollection(); 

    }
}
