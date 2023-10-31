using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repo;
        public BookService(IBookRepository repo)
        {
            this.repo = repo;
        }
        public int AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public Book GetBookbyId(int id)
        {
            return repo.GetBookbyId(id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return repo.GetBooks();
        }

        public int UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}
