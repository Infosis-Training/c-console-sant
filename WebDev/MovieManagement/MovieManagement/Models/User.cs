using Microsoft.AspNetCore.Identity;

namespace MovieManagement.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
