﻿using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBookbyId(int id);
        int AddBook(Book book);
        int UpdateBook(Book book);
        int DeleteBook(int id);
    }
}
