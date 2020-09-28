using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.netcore.Data;
using asp.netcore.Models;

namespace asp.netcore.Repository
{
    public class BookRepository:IBookRepository
    {
        private ApplicationDbContext _dbContext = null;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Book GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<Book>GetBooks()
        {
            return _dbContext.Books.ToList();
        }
        public void Add(Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }
        public void Edit(int id,Book book)
        {
            var edit = _dbContext.Books.SingleOrDefault(d => d.Id == id);
            edit.BookName = book.BookName;
            edit.Author = book.Author;
            edit.ISBN = book.ISBN;
            edit.PublishedDate = book.PublishedDate;
            edit.Genre = book.Genre;
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == id);
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }

    }
}
