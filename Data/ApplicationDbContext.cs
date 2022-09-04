using DotNet6Test.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet6Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Books> Books { get; set; }  //to create books table, with the respective no of columns specified in model
    }
}
