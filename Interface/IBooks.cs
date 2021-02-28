using System;
using System.Collections.Generic;
using Interface.Models;

namespace Interface
{
    public interface IBooks
    {
        List<Book> GetBooks();
        Book GetBook(int id);
        void DeleteBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
    }
}
