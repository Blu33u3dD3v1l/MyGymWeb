using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Views.Home;
using System.Net.Mail;
using static MyGymWeb.WebExtensions.AdminConstants;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net;

namespace MyGymWeb.Controllers
{

    public class HomeController : Controller
    {

      
        
        public IActionResult Index()
        {
            if (User.IsInRole(AdminRolleName))
            {
               return RedirectToAction("Index", "Admin", new { area = AreaName });
            }
            return View();
        }
      

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {

            if(statusCode == 404)
            {
                return this.View("Error404");
            }
            if (statusCode == 401)
            {
                return this.View("Error401");
            }

            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(IndexModelDto model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                    var message = new MailMessage();
                    message.To.Add(new MailAddress("kachamakov84@abv.bg"));
                    message.From = new MailAddress("kachamakov@abv.bg");
                    message.Subject = "Your email subject";
                    message.Body = string.Format(body, model.Name, model.Subject, model.Message);
                    message.IsBodyHtml = true;
                  

                    using (var smtp = new System.Net.Mail.SmtpClient())
                    {
                        var credential = new NetworkCredential
                        {
                            UserName = "kachamakov@abv.bg",
                            Password = "8402125840badboy"
                        };
                        smtp.Credentials = credential;
                        smtp.Host = "smtp.abv.bg";
                        smtp.Port = 465;
                        smtp.EnableSsl = false;

                        smtp.Send(message);
                    }
                }

                return RedirectToAction("Sent");
            }
            catch (Exception ex)
            {
                // Log or handle the exception
                Console.WriteLine($"Exception: {ex.Message}");
                Console.WriteLine($"Inner Exception: {ex.InnerException?.Message}");

                // Optionally, you may return an error view or redirect to an error page
                return View("Error");
            }
        }
        public ActionResult Sent()
        {
            return View();
        }

    }
}