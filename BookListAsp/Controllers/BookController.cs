using BookListAsp.Models;
using Interface;
using Interface.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace BookListAsp.Controllers
{
    public class BookController : Controller
    {
        private IBooks WorkBooks;

        public BookController(IBooks books) => WorkBooks = books;

        public ViewResult GetListBooks()
        {
            return View(WorkBooks.GetBooks());
        }

        [HttpGet]
        public ViewResult AddBook()
        {
            ViewBag.ItemAuthor = WorkBooks.GetAuthors();
            ViewBag.ItemGenre = WorkBooks.GetGenre();
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            WorkBooks.AddBook(book);
            return RedirectToAction("GetListBooks");
        }

        public IActionResult DeleteBook(int id)
        {
            WorkBooks.DeleteBook(id);
            return RedirectToAction("GetListBooks");
        }
    }
}
