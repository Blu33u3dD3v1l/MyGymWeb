using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
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
               .Where(x => x.IsActive)                   
               .Select(x => new TrainerViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Info = x.Info,
                   Moto = x.Moto,
                   Practis = x.Practis,
                   PricePerHour = x.PricePerHour,
                   IsAvailable = x.IsAvailable,
                   UserId = x.UserId,
                   User = x.User,
                   PhoneNumber = x.PhoneNumber,
                   

               })            
               .ToListAsync();

            return trainers;
        }

        public async Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId)
        {

            var currGym = await context.Gyms.FindAsync(gymId);
            var entity = new List<TrainerViewModel>();

            if (currGym?.Type == "BigBoxGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "BoxingTrainer" && x.IsActive)
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                        PhoneNumber = x.PhoneNumber,
                    }).ToListAsync();
            }
            if (currGym?.Type == "ClassicGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "ClassicTrainer" && x.IsActive)
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                        PhoneNumber = x.PhoneNumber,
                    }).ToListAsync();
            }
            if (currGym?.Type == "PilatesGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "PilatesTrainer" && x.IsActive)
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                        PhoneNumber = x.PhoneNumber,
                    }).ToListAsync();
               
            }
            if (currGym?.Type == "YogaGym")
            {
                entity = await context.Trainers
                    .Where(x => x.Type == "YogaTrainer" && x.IsActive)
                    .Select(x => new TrainerViewModel()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        ImageUrl = x.ImageUrl,
                        Info = x.Info,
                        Moto = x.Moto,
                        Practis = x.Practis,
                        PricePerHour = x.PricePerHour,
                        PhoneNumber = x.PhoneNumber,
                    }).ToListAsync();
            }

            return entity;

        }

        public async Task<TrainerViewModel> GetTrainerDescriptionAsync(Guid trainerId)
        {
            var currId = await context.Trainers.FirstOrDefaultAsync(x => x.Id == trainerId && x.IsActive);

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
                PhoneNumber = currId.PhoneNumber,
                
            };

            return entity;
        }

        public async Task<EditTrainerFormModel> GetEditTrainerAsync(Guid id)
        {
            var currTrainer = await context.Trainers
                .Where(x => x.IsActive)
               .FirstOrDefaultAsync(x => x.Id == id);

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
                PhoneNumber = currTrainer.PhoneNumber
            };
        }

        public async Task EditByIdAsync(Guid id, EditTrainerFormModel model)
        {
            var currTrainer = await context.Trainers
                .Where(x => x.IsActive)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (currTrainer == null)
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
            currTrainer.PhoneNumber = model.PhoneNumber;

            await this.context.SaveChangesAsync();


        }


        public async Task<bool> TrainerExistByUserId(string userId)
        {
            bool result = await this.context.Trainers
                 .AnyAsync(x => x.UserId == userId && x.IsActive);

            return result;
        }

      

        public async Task DeleteTrainerAsync(Guid id)
        {
            var currentTrainer = await context.Trainers
                .FirstOrDefaultAsync(x => x.Id == id && x.IsActive);

            if (currentTrainer == null)
            {
                throw new NullReferenceException();
            }

            context.Remove(currentTrainer);
            await context.SaveChangesAsync();
        }

        public Task<bool> GetTrainerUserId(Guid trainerId, string userId)
        {

            var a = context.Trainers
                .AnyAsync(x => x.Id == trainerId && x.UserId == userId);

            return a;
        }

        public async Task<TrainerDetailsRemoveViewModel> GetForDeleteAsync(Guid id, TrainerDetailsRemoveViewModel model)
        {
            var currTrainer = await context.Trainers
                .FirstOrDefaultAsync(x => x.Id == id);

            if (currTrainer == null)
            {
                throw new NullReferenceException(); 
            }


            model.Id = currTrainer.Id;
            model.Name = currTrainer.Name;
            model.Info = currTrainer.Info;
            model.ImageUrl = currTrainer.ImageUrl;

            return model;

        }

        public async Task AddTrainerAsync(AddTrainerFormModel model)
        {
            var trainer = new Trainer()
            {
                Name = model.Name,
                PricePerHour = model.PricePerHour,
                Type = model.Type,
                ImageUrl = model.ImageUrl,
                Info = model.Info,
                Moto = model.Moto,
                Practis = model.Practis,                
                PhoneNumber = model.PhoneNumber,

            };

            await context.Trainers.AddAsync(trainer);
            await context.SaveChangesAsync();
        }

        public async Task QuitTrainerAsync(string userId, TrainerQuitViewModel model)
        {
            Trainer? currentTrainer = await context.Trainers.FirstOrDefaultAsync(a => a.UserId == userId);

            if (currentTrainer == null)
            {
                throw new Exception();
            }

            var trainer = new Apply()
            {
                Id = currentTrainer.Id,
                Name = currentTrainer.Name,
                PricePerHour = currentTrainer.PricePerHour,
                Type = currentTrainer.Type,
                ImageUrl = currentTrainer.ImageUrl,
                Info = currentTrainer.Info,
                Moto = currentTrainer.Moto,
                Practis = currentTrainer.Practis,
                PhoneNumber = currentTrainer.PhoneNumber,
                UserId = userId,
                ForApplication = "For Quit"



            };

         
            await context.Applies.AddAsync(trainer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteTraineForApplyrAsync(Guid id)
        {
            var currentTrainer = await context.Trainers
                .FirstOrDefaultAsync(x => x.Id == id && x.IsActive);

            if (currentTrainer == null)
            {
                throw new NullReferenceException();
            }

            context.Remove(currentTrainer);
            await context.SaveChangesAsync();
        }
    }
}
