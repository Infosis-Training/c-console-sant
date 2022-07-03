using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieManagement.Database;
using MovieManagement.Models;
using MovieManagement.ViewModel;

namespace MovieManagement.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        public UserController(UserManager<User> userManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _userManager.Users.Select(c => new UserViewModel()
            {
                FirstName       = c.FirstName,
                LastName        = c.LastName,
                UserName        = c.UserName,
                PhoneNumber     = c.PhoneNumber,
                EmailConfirmed  = c.EmailConfirmed,
                Role            = string.Join(",", _userManager.GetRolesAsync(c).Result.ToArray())
            }).ToList();

            return View(users);
        }

        public IActionResult Add()
        {
            List<IdentityRole> tempEmpList = new List<IdentityRole>();
            tempEmpList = _context.Roles.ToList();
            ViewData["tempEmpList"] = tempEmpList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Store([Bind("UserName", "Password", "FirstName", "LastName", "PhoneNumber", "Role")]UserViewModel user)
        {
            if (user == null)
            {
                return View();
            }
            else
            {
                var usr = new User()
                {
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName= user.LastName,
                    PasswordHash = user.Password,
                    EmailConfirmed = true,
                    PhoneNumber =  user.PhoneNumber,

                };

                await _userManager.CreateAsync(usr, user.Password);
                await _userManager.AddToRoleAsync(usr, user.Role);

                return Redirect(nameof(Index));
            }
        }
    }
}
