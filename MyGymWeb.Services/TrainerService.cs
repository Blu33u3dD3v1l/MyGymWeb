﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using System.ComponentModel.DataAnnotations;

namespace MyGymWeb.Services
{
    public class TrainerService : ITrainerService
    {
        private readonly MyGymProjectDbContext context;

        public TrainerService(MyGymProjectDbContext _context)
        {
            context = _context;
        }

        public async Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync()
        {
            var trainers = await context.Trainers
               .Select(x => new TrainerViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Info = x.Info,
                   Moto = x.Moto,
                   Practis = x.Practis,
                   PricePerHour = x.PricePerHour,

               }).ToListAsync();

            return trainers;
        }

        public async Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId)
        {

            var currGym = await context.Gyms.FindAsync(gymId);
            var entity = new List<TrainerViewModel>();

            if (currGym?.Type == "BigBoxGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "BoxingTrainer")
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                    }).ToListAsync();
            }
            if (currGym?.Type == "ClassicGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "ClassicTrainer")
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                    }).ToListAsync();
            }
            if (currGym?.Type == "PilatesGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "PilatesTrainer")
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                    }).ToListAsync();
            }
            if (currGym?.Type == "YogaGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "YogaTrainer")
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                    }).ToListAsync();
            }

            return entity;

        }

        public async Task<TrainerViewModel> GetTrainerDescriptionAsync(int trainerId)
        {
            var currId = await context.Trainers.FindAsync(trainerId);

            if (currId == null)
            {
                throw new ArgumentNullException("Id Not Found!");
            }

            var entity = new TrainerViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                ImageUrl = currId.ImageUrl,
                Moto = currId.Moto,
                Info = currId.Info,
                Practis = currId.Practis,
                PricePerHour = currId.PricePerHour,
                Type = currId.Type,
            };

            return entity;
        }

        public async Task<EditTrainerFormModel> GetEditTrainerAsync(int id)
        {
             var currTrainer = await context.Trainers.
                FirstOrDefaultAsync(x => x.Id == id);

            if (currTrainer == null)
            {
                throw new Exception();
            }

            return new EditTrainerFormModel()
            {
                Id = currTrainer.Id,
                Name = currTrainer.Name,
                ImageUrl = currTrainer.ImageUrl,
                Moto = currTrainer.Moto,
                Info = currTrainer.Info,
                Practis = currTrainer.Practis,
                PricePerHour = currTrainer.PricePerHour,
                Type = currTrainer.Type,
            };
        }

        public async Task EditByIdAsync(int id, EditTrainerFormModel model)
        {
            var currTrainer = await context.Trainers.
                FirstOrDefaultAsync(x => x.Id == id);

            if(currTrainer == null)
            {
                throw new Exception();
            }

            currTrainer.Id = id;
            currTrainer.Name = model.Name;
            currTrainer.PricePerHour = model.PricePerHour;
            currTrainer.Info = model.Info;
            currTrainer.Practis = model.Practis;
            currTrainer.Moto = model.Moto;
            currTrainer.ImageUrl = model.ImageUrl;
            currTrainer.Type = model.Type;

            await this.context.SaveChangesAsync();
            
            
        }



      
    }
}
