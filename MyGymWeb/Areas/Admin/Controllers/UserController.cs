using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services;
using MyGymWeb.Services.Admin;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {

        private readonly IUserService userService;

        public UserController(IUserService _userService)
        {
            userService = _userService;
        }

      
        public async Task<IActionResult> All()
        {
            var model = await userService.All();
            return View(model);
        }

        public async Task<IActionResult> Delete(string userId)
        {

            await userService.DeleteUsersAsync(userId);

            return RedirectToAction("All", "User", "Admin");
        }

    }
}
