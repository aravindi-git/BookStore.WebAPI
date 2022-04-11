using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Interfaces
{
    public interface IBookServices
    {
        List<Book> GetBooks();
        Book GetBook(string Id); 
        Book AddBook (Book book);
        void DeleteBook(string id);
        Book UpdateBook(Book book);

    }
}
