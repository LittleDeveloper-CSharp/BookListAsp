using ClassesModels.Interface;
using ClassesModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookListAsp.Controllers
{
    public class AuthorController : Controller
    {
        private IAuthor Author { get; set; }
        public AuthorController(IAuthor author) => Author = author;
        public ViewResult GetListAuthors()
        {
            return View(Author.GetAuthors());
        }
        [HttpGet]
        public ViewResult AddAuthor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAuthor(Author author)
        {
            Author.AddAuthor(author);
            return RedirectToAction(nameof(GetListAuthors));
        }
        public IActionResult DeleteAuthor(int id)
        {
            Author.DeleteAuthor(id);
            return RedirectToAction(nameof(GetListAuthors));     
        }
    }
}
