using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Admin;
using System.Security.Claims;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;
    
namespace MyGymWeb.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService userService;


        public UserController(IUserService _userService)
        {
            userService = _userService;

        }
        public async Task<IActionResult> Buy(int id)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                await userService.BuyProductAsync(id, userId!);

                TempData[SuccessMessage] = "You Successfully buy a product!";
                

            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "Not enough Money!";
            }

            return RedirectToAction("All", "Product");
        }

        public async Task<IActionResult> Mine()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await userService.GetAllProductsForBuyAsync(userId!);

            return View("Mine", model);
        }
        public async Task<IActionResult> Return(int id)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await userService.ReturnProductAsync(userId!, id);
                TempData[SuccessMessage] = "You Successfully returned product!";
            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "User or Product not found!";
            }

            return RedirectToAction("Mine", "User");
        }
    }
}
