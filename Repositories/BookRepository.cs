using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryAPI.models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _context;

        public BookRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Book> CreateBook(Book books)
        {
            _context.Books.Add(books);
            await _context.SaveChangesAsync();

            return books;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(bookToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
           return await _context.Books.FindAsync(id);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task Update(Book books)
        {
            _context.Entry(books).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}