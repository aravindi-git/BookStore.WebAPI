using BookStore.Models.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Book> _books; 
        public DbClient(IOptions<BookStoreDbConfig> bookStoreDbConfig)
        {
            var client = new MongoClient(bookStoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookStoreDbConfig.Value.Database_Name);
            _books = database.GetCollection<Book>(bookStoreDbConfig.Value.Books_Collection_Name); 

        }
        public IMongoCollection<Book> GetBooksCollection() => _books; 
        
    }
}
