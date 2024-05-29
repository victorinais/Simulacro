using gestion.Controllers.Authors;
using gestion.Models;
using Microsoft.EntityFrameworkCore;

namespace gestion.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options): base(options)
        {
        }
        public DbSet<Author> Authors { get; set;}
        public DbSet<Book> Books { get; set;}
        public DbSet<Editorial> Editorials { get; set;}
    }
}