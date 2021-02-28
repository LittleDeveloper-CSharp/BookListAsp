using Interface;
using Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Data.Entity;

namespace BookListAsp.Models
{
    public class WorkWithBook : IBooks
    {
        public void AddBook(Book book)
        {
            using(var st = new ContextModel())
            {
                book.Author = this.GetAuthors().First(x => x.AuthorId == book.idAuthor);
                book.Genre = this.GetGenre().First(x => x.GenreId == book.idGenre);
                st.Entry(book.Genre).State = EntityState.Unchanged;
                st.Entry(book.Author).State = EntityState.Unchanged;
                st.Books.AddOrUpdate(book);
                st.SaveChanges();
            }
        }

        public void DeleteBook(int id)
        {
            using (var st = new ContextModel())
            {
                var book = st.Books.FirstOrDefault(x => x.BookId == id);
                if (!(book is null))
                    st.Books.Remove(book);
                st.SaveChanges();
            }
        }

        public Book GetBook(int id)
        {
            using(var st = new ContextModel())
            {
                return st.Books.Include(x => x.Author).Include(x => x.Genre).FirstOrDefault(x => x.BookId == id);
            }
        }

        public List<Book> GetBooks()
        {
            using(var st = new ContextModel())
            {
                return st.Books.Include(x=>x.Author).Include(x=>x.Genre).ToList();
            }
        }

        public void UpdateBook(Book book) => AddBook(book);
    }
    public static class WorkWithBookExtension
    {
        public static List<Author> GetAuthors(this IBooks work)
        {
            using(var st = new ContextModel())
            {
                return st.Authors.ToList();
            }
        }
        public static List<Genre> GetGenre(this IBooks work)
        {
            using (var st = new ContextModel())
            {
                return st.Genres.ToList();
            }
        }
    }
}
