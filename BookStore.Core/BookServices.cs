using BookStore.Core.Interfaces;
using BookStore.Data; 
using BookStore.Models.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BookStore.Core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books; 
        public BookServices(IDbClient dbClient)
        {
            _books = dbClient.GetBooksCollection();   
        }

        public Book AddBook(Book book)
        {
            _books.InsertOne(book);
            return book; 
        }

        public void DeleteBook(string id)
        {
            _books.DeleteOne(id); 
        }

        public Book GetBook(string Id) => _books.Find(book => book.Id == Id).FirstOrDefault();

        public List<Book> GetBooks() => _books.Find(book => true).ToList();

        public Book UpdateBook(Book book)
        {
            
            if(GetBook(book.Id) != null )
            {
                _books.ReplaceOne(b => b.Id == book.Id, book); 
            }
            return book;    
        }

    }
}
