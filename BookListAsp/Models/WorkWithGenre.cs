using ClassesModels;
using ClassesModels.Interface;
using ClassesModels.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListAsp.Models
{
    public class WorkWithGenre : IGenre
    {
        public void AddGenre(Genre genre)
        {
            using(ContextModel st = new ContextModel())
            {
                st.Genres.AddOrUpdate(genre);
                st.SaveChanges();
            }
        }

        public void DeleteGenre(int id)
        {
            using (ContextModel st = new ContextModel())
            {
                var item = st.Genres.First(x => x.GenreId == id);
                st.Genres.Remove(item);
                st.SaveChanges();
            }
        }

        public List<Genre> GetGenres()
        {
            using(ContextModel st =new ContextModel())
            {
                return st.Genres.ToList();
            }
        }

        public Genre GetGenre(int id)
        {
            using(ContextModel st= new ContextModel())
            {
                return st.Genres.First(x => x.GenreId == id);
            }
        }

        public void UpdateGenre(Genre genre) => AddGenre(genre);
    }
}
