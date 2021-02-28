using System.Collections.Generic;
using Interface.Models;

namespace Interface
{
    public interface IAuthor
    {
        List<Author> GetAuthors();
        Author GetAuthor(int id);
        void DeleteAuthor(int id);
        void AddAuthor(Author author);
        void UpdateAuthor(Author author);
    }
}
