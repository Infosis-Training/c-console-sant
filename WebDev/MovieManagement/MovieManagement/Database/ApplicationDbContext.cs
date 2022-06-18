using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;

namespace MovieManagement.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Table name, as per Model created
        public DbSet<Movie> Movies { get; set; }

        //Table name, as per Model created
        public DbSet<MovieManagement.Models.Crew>? Crew { get; set; }
    }
}
