using MathNet.Numerics;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Enums;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;
using MyGymWeb.Services.Models.Trainer;

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
                .Include(x => x.UsersTrainers)
               .Select(x => new TrainerViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   ImageUrl = x.ImageUrl,
                   Info = x.Info,
                   Motto = x.Motto,
                   Practis = x.Practis,
                   PricePerHour = x.PricePerHour,
                   IsAvailable = x.IsAvailable,
                   UserId = x.UserId,
                   User = x.User,
                   PhoneNumber = x.PhoneNumber,
                   UsersTrainers = x.UsersTrainers
                   

               })            
               .ToListAsync();

            return trainers;
        }

        public async Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId)
        {

            var currGym = await context.Gyms.FindAsync(gymId);
            if(currGym == null)
            {
                throw new ArgumentNullException();
            }


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
                        Motto = x.Motto,
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
                        Motto = x.Motto,
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
                        Motto = x.Motto,
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
                        Motto = x.Motto,
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
                throw new ArgumentNullException();
            }

            var entity = new TrainerViewModel()
            {
                Id = currId.Id,
                Name = currId.Name,
                ImageUrl = currId.ImageUrl,
                Motto = currId.Motto,
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
                throw new ArgumentNullException();
            }

            return new EditTrainerFormModel()
            {
                Id = currTrainer.Id,
                Name = currTrainer.Name,
                ImageUrl = currTrainer.ImageUrl,
                Motto = currTrainer.Motto,
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
                throw new ArgumentNullException();
            }

            currTrainer.Id = id;
            currTrainer.Name = model.Name;
            currTrainer.PricePerHour = model.PricePerHour;
            currTrainer.Info = model.Info;
            currTrainer.Practis = model.Practis;
            currTrainer.Motto = model.Motto;
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
                Motto = model.Motto,
                Practis = model.Practis,                
                PhoneNumber = model.PhoneNumber,

            };

            await context.Trainers.AddAsync(trainer);
            await context.SaveChangesAsync();
        }


        public async Task DeleteTrainerForApplyAsync(Guid id)
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

        public async Task<AllTrainersFilteredAndPagedServiceModel> AllAsync(AllTrainersQueryModel model)
        {

            IQueryable<Trainer> trainerQuery = this.context.Trainers.AsQueryable();

            if (!string.IsNullOrEmpty(model.SeachString))
            {
                string wildCard = $"%{model.SeachString.ToLower()}%";

                trainerQuery = trainerQuery.Where(h => EF.Functions.Like(h.Name, wildCard));


            }

            if (model.TrainerSorting == 0)
            {
                model.TrainersPerPage = 4;
                trainerQuery = model.TrainerSorting switch
                {
                    TrainerSorting.Name => trainerQuery.OrderBy(x => x.Name),
                    _ => trainerQuery.OrderBy(x => x.Name)
                };


            }
            else
            {
                model.TrainersPerPage = 60;
                trainerQuery = model.TrainerSorting switch
                {

                    TrainerSorting.PriceAscending => trainerQuery.OrderBy(x => x.PricePerHour),
                    TrainerSorting.PriceDescending => trainerQuery.OrderByDescending(x => x.PricePerHour),
                    _ => trainerQuery
                };
            }

            IEnumerable<AllTrainersViewModel> allTrainers = await trainerQuery.Skip((model.CurrentPage - 1) * model.TrainersPerPage).Take(model.TrainersPerPage)
           .Select(x => new AllTrainersViewModel()
           {

               Id = x.Id,
               ImageUrl = x.ImageUrl,
               Info = x.Info,
               Motto = x.Motto,
               Name = x.Name,
               Practis = x.Practis,
               PricePerHour = x.PricePerHour,
               Type = x.Type,

           }).ToArrayAsync();


            int totalTrainers = trainerQuery.Count();

            return new AllTrainersFilteredAndPagedServiceModel()
            {
                TotalTrainersCount = totalTrainers,
                Trainers = allTrainers
            };
        }

        public void ReactToTrainer(Guid trainerId, string userId, bool isLike)
        {
            var existingReaction = context.TrainerReactions
         .FirstOrDefault(r => r.TrainerId == trainerId && r.UserId == userId); // ⬅️ правилно

            if (existingReaction != null)
            {
                if (existingReaction.IsLike == isLike)
                {
                    // Clicked same again => remove
                    context.TrainerReactions.Remove(existingReaction);
                }
                else
                {
                    existingReaction.IsLike = isLike;
                    context.TrainerReactions.Update(existingReaction);
                }
            }
            else
            {
                context.TrainerReactions.Add(new TrainerReaction
                {
                    TrainerId = trainerId,
                    UserId = userId,
                    IsLike = isLike
                });
            }

            context.SaveChanges();
        }

        public (int likes, int dislikes, bool? userReaction) GetReactions(Guid trainerId, string userId)
        {
            var reactions = context.TrainerReactions.Where(r => r.TrainerId == trainerId);
            int likes = reactions.Count(r => r.IsLike);
            int dislikes = reactions.Count(r => !r.IsLike);
            bool? userReaction = reactions.FirstOrDefault(r => r.UserId == userId)?.IsLike;

            return (likes, dislikes, userReaction);
        }
    }
}
