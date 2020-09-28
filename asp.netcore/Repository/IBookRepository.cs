using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.netcore.Models;

namespace asp.netcore.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
        void Add(Book book);
        void Edit(int id, Book book);
        void Delete(int id);

    }
}
