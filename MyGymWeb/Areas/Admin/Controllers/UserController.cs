using Microsoft.AspNetCore.Mvc;
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

        //public async Task<IActionResult> Delete(string id)
        //{
           

        //    try
        //    {               
        //            await userService.DeleteUserAsync(id);
        //            TempData[SuccessMessage] = "Successful delete user!";
                              
        //    }
        //    catch (Exception)
        //    {

        //        TempData[ErrorMessage] = "The Admin cannot be deleted!";
        //    }
           


        //    return RedirectToAction("All", "User", "Admin");
        //}

    }
}
