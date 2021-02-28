using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class Book
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        [NotMapped]
        public int idAuthor { get; set; }
        [NotMapped]
        public int idGenre { get; set; }
        public virtual Author Author { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
