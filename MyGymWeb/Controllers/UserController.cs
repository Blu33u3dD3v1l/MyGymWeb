using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Data.Models;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;
using MyGymWeb.Services.Interface;
using System.Security.Claims;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;

namespace MyGymWeb.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly IUserService userService;
        private readonly ITrainerService trainerService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService _userService, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager, ITrainerService _trainerService)
        {
            userService = _userService;
            userManager = _userManager;
            signInManager = _signInManager;
            trainerService = _trainerService;

        }
        public async Task<IActionResult> Buy(int id)
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            await userService.BuyProductAsync(id, userId!);


            return RedirectToAction("Cart", "User");
        }

        public async Task<IActionResult> Cart()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await userService.GetAllProductsForRefresh(userId!);

            return View("RefreshedMine", model);
        }
        public async Task<IActionResult> Return(int id)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await userService.ReturnProductAsync(userId!, id);

            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "User or Product not found!";
            }

            return RedirectToAction("Cart", "User");
        }

       

        [HttpGet]
        public IActionResult Appointment(Guid trainerId)
        {
            var model = new AppointmentFormModel
            {
                TrainerId = trainerId
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Appointment(Guid trainerId, AppointmentFormModel model)
        {

            var currentId = User.GetId();
            try
            {

                await this.userService.AddAppointmentAsync(trainerId, currentId!, model);
                TempData[SuccessMessage] = "You successfuly add an appointment!";
            }
            catch (InvalidOperationException)
            {

                TempData[ErrorMessage] = "The Name of the Trainer is Incorrect!Please try again.";

            }
            catch (InvalidDataException)
            {

                TempData[ErrorMessage] = "The Date has Expired! Please try again.";

            }

            return RedirectToAction("All", "Trainer");
        }

        public async Task<IActionResult> MyApps()
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            var model = await userService.GetMyTrainersAsync(userId!);
            return View(model);
        }

        public async Task<IActionResult> Cancel(int id)
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await userService.CancelUserApplicationAsync(id);
                TempData[SuccessMessage] = "Your Appointment is canceled successfuly!";

            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "There is no Appointment or Trainer to remove!";
            }

            return RedirectToAction("MyApps", "User");
        }


        public async Task<IActionResult> AllMyTrainers()
        {

            var ids = this.User.GetId();
            var model = await userService.GetAllMyTrainersAsync(ids!);
            return View("AllMyTrainers", model);

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {

            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new RegisterFormModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {

                FirstName = model.FirstName,
                LastName = model.LastName,


            };

            await this.userManager.SetEmailAsync(user, model.Email);
            await this.userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {

                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(model);
            }

            await this.signInManager.SignInAsync(user, false);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl = null)
        {


            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LoginFormModel()
            {
                ReturnUrl = returnUrl,
            };

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByNameAsync(model.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid login");

            return View(model);
        }

        public async Task<IActionResult> BuyProducts(int productId)
        {

            var ids = this.User.GetId();
            var prod = this.userService.GetAllProductsForBuyAsync(ids).Result;

            await Task.Delay(1500);

            try
            {
               
                await userService.BuyProducts(productId, ids);
                if (prod?.Count() == 0)
                {
                    TempData[SuccessMessage] = "You bought a product!";
                }
                else
                {
                    TempData[SuccessMessage] = $"You bought {prod?.Count()} products!";
                }

            }
            catch (ArgumentException)
            {

                TempData[ErrorMessage] = "Not enough money!";
            }
            catch (NullReferenceException)
            {
                TempData[ErrorMessage] = "No products added!";
            }

            return RedirectToAction("Cart", "User");
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }


      
        public async Task<IActionResult> SaveCoupon(string couponCode)
        {

            var ids = this.User.GetId();

            if(couponCode != null && couponCode == "AAA-12345")
            {
                try
                {
                    await userService.Code(ids, couponCode);
                }
                catch (InvalidOperationException)
                {

                    TempData[ErrorMessage] = "You have already used a promo code!";

                }
            }

            return RedirectToAction("RefreshedMine", "User");
           
        }

        public async Task<IActionResult> RefreshedMine()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await userService.GetAllProductsForRefresh(userId!);

            return View("RefreshedMine", model);
        }


        public async Task<IActionResult> Resign(Guid id)
        {

           

            await trainerService.DeleteTrainerForApplyAsync(id);
            TempData[SuccessMessage] = "Updated Trainer Status";

            return RedirectToAction("All", "Trainer");
        
        }
        

           
    }
}