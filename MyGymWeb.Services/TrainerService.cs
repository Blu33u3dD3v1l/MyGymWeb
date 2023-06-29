using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

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
            };

            return entity;
        }

    }
}
