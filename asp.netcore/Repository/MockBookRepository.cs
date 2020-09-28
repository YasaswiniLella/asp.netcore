using asp.netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netcore.Repository
{
    public class MockBookRepository:IBookRepository
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(int id, Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);
        }
        public IEnumerable<Book>GetBooks()
        {
            return new List<Book>
            {
                new Book{Id=1,BookName="Life Is What You Make It",Author="Preethi Shenoy",ISBN="1234566",PublishedDate=Convert.ToDateTime("1/12/2010")},
                new Book{Id=2,BookName="Wings of Fire",Author="Dr. A.P.J.Adbul Kalam ",ISBN="143456",PublishedDate=Convert.ToDateTime("1/09/2012")},
                new Book{Id=3,BookName="Three Mistakes of my Life",Author="Chetan Bhagat",ISBN="15674353",PublishedDate=Convert.ToDateTime("1/05/2005")},


            };
        }

    }
}
