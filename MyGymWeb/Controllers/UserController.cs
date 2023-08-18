using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Data.Models;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Admin;
using System.Security.Claims;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;
    
namespace MyGymWeb.Controllers
{
    [Authorize]
    public class UserController : Controller
    {

        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
       


        public UserController(IUserService _userService, UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userService = _userService;
            userManager = _userManager;
            signInManager = _signInManager;
           
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

            return RedirectToAction("Mine", "User");
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

        [HttpGet]
        public  async Task<IActionResult> Appointment(Guid id)
        {

            string? currentId =  this.User.GetId();

            try
            {
                await this.userService.AppointmentExistByUserId(currentId, id);
            }
            catch (Exception)
            {

                TempData[WarningMessage] = "You allready have pending appointment with this Trainer!";
                return RedirectToAction("Index", "Home");
            }
          
           
                return View();
        }

        [HttpPost]
        public async Task<IActionResult> Appointment(Guid id,  AppointmentFormModel model)
        {


            var currentId = User.GetId();
            try
            {
                
                await this.userService.AddAppointmentAsync(id, currentId!, model);
                //await this.userService.TrainerUserRelationAsync(currentId!, id);
                TempData[SuccessMessage] = "You successfuly add an appointment!";
            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "The Name of the Trainer is Incorrect!";
               
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

            return RedirectToAction("MyApps","User");
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

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }




}

