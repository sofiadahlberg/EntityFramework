using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> Books {get; set; }
        public DbSet<Name> Names {get; set;}
    }
}