using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using asp.netcore.Models;
using asp.netcore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace asp.netcore.Controllers
{
    public class BooksController : Controller
    {
        private IBookRepository _bookRepos = null; 
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.Add(book);
            return RedirectToAction("Index", "Books");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var edit= _bookRepos.GetBookById(id);
            return View(edit);
        }
        [HttpPost]
        public IActionResult Edit(int id,Book book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.Edit(id, book);
            return RedirectToAction("Index", "Books");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _bookRepos.Delete(id);
            return RedirectToAction("Index", "Books");
        }
        public IActionResult newaction()
        {
            return View();
        }

    }
}
