﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Infrastructure.Extensions;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Common.Constants.NotificationMessagesConstants;

namespace MyGymWeb.Controllers
{
    [Authorize]
    public class ApplyController : Controller
    {
        private readonly IApplyService applyService;
        private readonly ITrainerService trainerService;


        public ApplyController(IApplyService _applyService, ITrainerService _trainerService)
        {

            applyService = _applyService;
            trainerService = _trainerService;
        }
        [HttpGet]
        public async Task<IActionResult> Apply()
        {
           
            string? currentId = this.User.GetId();


            if(currentId != null)
            {

                bool isApplier = await this.applyService.ApplierExistByUserId(currentId);
                if (isApplier)
                {

                    TempData[ErrorMessage] = "You allready have pending application!";

                    return RedirectToAction("Index", "Home");

                }

                bool isTrainer = await this.trainerService.TrainerExistByUserId(currentId);
                if (isTrainer)
                {
                    TempData[WarningMessage] = "You are a trainer!";

                    return RedirectToAction("Index", "Home");
                }
            }
             


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Apply(TrainerQuitViewModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var currentId = User.GetId();


            if (currentId != null)
            {
                try
                {
                    await this.applyService.AddApplyAsync(currentId, model);
                    TempData[SuccessMessage] = "You successfuly post an application!";
                }
                catch (Exception)
                {

                    ModelState.AddModelError(string.Empty, "Unexpected Error");
                    return View(model);
                }
               
            }
           
            return RedirectToAction("All", "Trainer");
        }


    }
}
