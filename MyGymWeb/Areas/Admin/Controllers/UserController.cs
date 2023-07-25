using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Data.Models;
using MyGymWeb.Services.Admin;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;


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

    }
}
