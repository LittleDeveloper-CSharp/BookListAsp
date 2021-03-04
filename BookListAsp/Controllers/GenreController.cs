using Microsoft.AspNetCore.Mvc;
using ClassesModels.Interface;
using ClassesModels.Models;

namespace BookListAsp.Controllers
{
    public class GenreController : Controller
    {
        private IGenre Genre { get; set; }
        public GenreController(IGenre genre) => Genre = genre;
        public ViewResult GetListGenres()
        {
            return View(Genre.GetGenres());
        }

        [HttpGet]
        public ViewResult AddGenre()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGenre(Genre genre)
        {
            Genre.AddGenre(genre);
            return RedirectToAction(nameof(GetListGenres));
        }
        public IActionResult DeleteGenre(int id)
        {
            Genre.DeleteGenre(id);
            return RedirectToAction(nameof(GetListGenres));
        }
    }
}
