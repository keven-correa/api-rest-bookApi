using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryAPI.models;

namespace LibraryAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<Book> CreateBook(Book books);
        Task Update(Book books);
        Task Delete (int id);
    }
}