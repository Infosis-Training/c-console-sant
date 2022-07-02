using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Models;
using MovieManagement.ViewModel;

namespace MovieManagement.Database
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        internal Task<bool> RoleExistsAsync(string v)
        {
            throw new NotImplementedException();
        }

        //Table name, as per Model created
        public DbSet<Movie> Movies { get; set; }

        //Table name, as per Model created
        public DbSet<MovieManagement.Models.Crew>? Crew { get; set; }

        //Table name, as per Model created
        public DbSet<MovieManagement.Models.Genre>? Genre { get; set; }

    }
}
