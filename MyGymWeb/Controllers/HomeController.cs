using Humanizer.DateTimeHumanizeStrategy;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using System.Diagnostics;
using static MyGymWeb.Areas.Admin.AdminConstants;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;

namespace MyGymWeb.Controllers
{

    public class HomeController : Controller
    {

        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserStore<ApplicationUser> userStore;

        public HomeController(SignInManager<ApplicationUser> _signInManager, UserManager<ApplicationUser> _userManager, IUserStore<ApplicationUser> _userStore)
        {
            signInManager = _signInManager;
            userManager = _userManager;
            userStore = _userStore;

        }

        [ResponseCache(Duration = 60)]
        public IActionResult Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
                return RedirectToAction("Index", "Admin", new { area = AreaName });
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            ApplicationUser user = new ApplicationUser()
            {
               
                FirstName = model.FirstName,
                LastName = model.LastName,

            };

           await this.userManager.SetEmailAsync(user, model.Email);
           await this.userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = await this.userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            await this.signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl,
            };
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
           if(!ModelState.IsValid)
            {
                return this.View(model);
            }


          var result = await this.signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

            if (!result.Succeeded)
            {
                TempData[ErrorMessage] = "There was error while loggin!Please try again later or contact administrator!";
                return View(model);
            }

            return this.Redirect(model.ReturnUrl ?? "/Home/Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      
    }
}