﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using static MyGymWeb.Infrastructure.Extensions.ClaimsExtensions;

namespace MyGymWeb.Controllers
{
    [Authorize]
    public class TrainerController : Controller
    {

        private readonly ITrainerService trainerService;

        public TrainerController(ITrainerService _trainerService)
        {
            trainerService = _trainerService;
        }


        public async Task<IActionResult> All()
        {
            var t = await trainerService.GetAllTrainersAsync();
            return View(t);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid trainerId)
        {
            var model = await trainerService.GetTrainerDescriptionAsync(trainerId);

            return View(model);
        }

        public async Task<IActionResult> TrainerView(int gymId)
        {
            var t = await trainerService.GetTypeTrainersAsync(gymId);
            return View(t);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var view = await trainerService.GetEditTrainerAsync(id);
            return View(view);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, EditTrainerFormModel model)
        {
           if(!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainerService.EditByIdAsync(id, model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Trainer");
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new AddTrainerFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddTrainerFormModel model)
        {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await this.trainerService.AddTrainerAsync(model);

            }
            catch (Exception)
            {

                ModelState.AddModelError(string.Empty, "Unexpected Error");
            }

            return RedirectToAction("All", "Trainer");


        }


        public async Task<IActionResult> Become()
        {

            string? userId = this.User.GetId();
            bool isTrainer = await this.trainerService.TrainerExistByUserId(userId);

            if (isTrainer)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Become(AddTrainerFormModel model)
        {
            string? userId = this.User.GetId();
            bool isTrainer = await this.trainerService.TrainerExistByUserId(userId);

            if (isTrainer)
            {
                return RedirectToAction("Index", "Home");
            }

            await this.trainerService.BecomeTrainerAsync(userId, model);

            return RedirectToAction("All", "Trainer");
        }



    }
}
