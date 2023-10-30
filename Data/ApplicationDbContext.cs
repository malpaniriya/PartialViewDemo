using Microsoft.EntityFrameworkCore;
using PartialViewDemo.Models;

namespace PartialViewDemo.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<Book> Books { get; set; }


    }

}
