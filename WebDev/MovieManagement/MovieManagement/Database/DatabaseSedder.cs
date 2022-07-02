using Microsoft.AspNetCore.Identity;

namespace MovieManagement.Database
{
    public class DatabaseSedder
    {

        private readonly ApplicationDbContext _db;

        public DatabaseSedder(ApplicationDbContext db) // Dependency Injection
        {
            _db = db;
        }

        private async Task CreateRole()
        {
            bool x = await _db.RoleExistsAsync("Admin");

            var role = new IdentityRole();
            role.Name = "Admin";

            //await _db.CreateAsync(role);
        }
    }
}
