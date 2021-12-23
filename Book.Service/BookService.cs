using Book.Database.Repo;
using Book.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Service
{

    public interface IBookService
    {
        Task<IEnumerable<Books>> GetBooks();
        Task<Books> GetBookById(int id);
        Books AddBook(Books books);
        Task<Books> UpdateBook(Books books);
        Task<bool> DeleteBook(int id);
    }

    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public Books AddBook(Books books)
        {
            _bookRepository.Add(books);
            return books;
        }

        public async Task<bool> DeleteBook(int id)
        {
            Books bookId = await _bookRepository.GetById(id); 

            if(bookId != null)
            {
                _bookRepository.Delete(bookId);
                return true;
            }
            return false;
        }

        public async Task<Books> GetBookById(int id)
        {
            return await _bookRepository.GetById(id);
        }

        public async Task<IEnumerable<Books>> GetBooks()
        {
            return await _bookRepository.Get();
        }

        public async Task<Books> UpdateBook(Books books)
        {
            Books _books = await _bookRepository.GetById(books.BookId);
            if(books != null)
            {
                _books.BookName = books.BookName;
                _books.AuthorId = books.AuthorId;
                _bookRepository.Update(_books);
                return books;
            }
            return books;


        }
    }
}
