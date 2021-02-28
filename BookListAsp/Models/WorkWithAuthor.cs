using Interface;
using Interface.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListAsp.Models
{
    public class WorkWithAuthor : IAuthor
    {
        public void AddAuthor(Author author)
        {
            using (ContextModel st = new ContextModel())
            {
                st.Authors.AddOrUpdate(author);
                st.SaveChanges();
            }
        }

        public void DeleteAuthor(int id)
        {
            using (ContextModel st = new ContextModel())
            {
                var item = st.Authors.First(x => x.AuthorId == id);
                st.Authors.Remove(item);
                st.SaveChanges();
            }
        }

        public List<Author> GetAuthors()
        {
            using(ContextModel st = new ContextModel())
            {
                return st.Authors.ToList();
            }
        }

        public Author GetAuthor(int id)
        {
            using(ContextModel st = new ContextModel()) 
            {
                return st.Authors.First(x => x.AuthorId == id); 
            }
        }

        public void UpdateAuthor(Author author) => AddAuthor(author);
    }
}
