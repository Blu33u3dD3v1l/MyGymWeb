﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            if (currentId == null)
            {
                throw new ArgumentNullException(nameof(currentId));
            }
           
            
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
                await this.userService.TrainerUserRelationAsync(currentId!, id);
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

        public async Task<IActionResult> Cancel(Guid trainerId, UserTrainersFormModel model)
        {

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await userService.CancelUserApplicationAsync(trainerId, userId!, model);
            }
            catch (Exception)
            {

                TempData[ErrorMessage] = "There is no Appointment to remove!";
            }

            return RedirectToAction("MyApps","User");
        }




    }
}
