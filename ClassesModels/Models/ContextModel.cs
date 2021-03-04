using System.Data.Entity;

namespace ClassesModels.Models
{
    public class ContextModel : DbContext
    {
        public ContextModel() : base("Data Source = DESKTOP-9STKAOI\\SQLEXPRESS; initial catalog = BookTest; Integrated Security = True;")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>()
                .HasMany(c => c.Book)
                .WithRequired(x => x.Genre)
                .WillCascadeOnDelete(true);
            modelBuilder.Entity<Author>()
                .HasMany(c => c.Book)
                .WithRequired(x => x.Author)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
    }
}