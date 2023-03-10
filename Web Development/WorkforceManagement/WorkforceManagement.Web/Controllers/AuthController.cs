using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WorkforceManagement.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Roles()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult AddRole()
        {            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);

            return RedirectToAction("Roles");
        }

        //Add action to list all users
        //Add another action to assign role to particular user

    }
}
