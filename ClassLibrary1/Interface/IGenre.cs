using System.Collections.Generic;
using ClassesModels.Models;

namespace ClassesModels.Interface
{
    public interface IGenre
    {
        List<Genre> GetGenres();
        Genre GetGenre(int id);
        void DeleteGenre(int id);
        void AddGenre(Genre genre);
        void UpdateGenre(Genre genre);
    }
}
