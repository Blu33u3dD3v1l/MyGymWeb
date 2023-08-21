using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;


namespace MyGymWeb.Services
{
  
    public class ApplyService : IApplyService
    {
        private readonly MyGymProjectDbContext context;

        public ApplyService(MyGymProjectDbContext _context)
        {
            context = _context;
        }      
        public async Task AddApplyAsync(string userId, TrainerQuitViewModel model)
        {

            var currentUser = await context.Applies.FirstOrDefaultAsync(a => a.UserId == userId);

            if(currentUser != null)
            {
                throw new Exception();
            }

             var apply = new Apply()
            {
                Name = model.Name,
                PricePerHour = model.PricePerHour,
                Type = model.Type,
                ImageUrl = model.ImageUrl,
                Info = model.Info,
                Motto = model.Motto,
                Practis = model.Practis,
                PhoneNumber = model.PhoneNumber,
                UserId = userId,
                ForApplication = "For Application"
            };

            await context.Applies.AddAsync(apply);
            await context.SaveChangesAsync();
        }
       
        public async Task<bool> ApplierExistByUserId(string userId)
        {
            bool applier = await context.Applies.AnyAsync(applies => applies.UserId == userId);
            return applier;
        }
      
        public async Task ApproveTrainerAsync(Guid id)
        {
            var currentTrainer = await context.Applies.FirstOrDefaultAsync(x => x.Id == id);

            if (currentTrainer == null)
            {
                throw new Exception();
            }

            var trainer = new Trainer()
            {
                Name = currentTrainer.Name,
                PricePerHour = currentTrainer.PricePerHour,
                Type = currentTrainer.Type,
                ImageUrl = currentTrainer.ImageUrl,
                Info = currentTrainer.Info,
                Motto = currentTrainer.Motto,
                Practis = currentTrainer.Practis,
                UserId = currentTrainer.UserId,
                PhoneNumber = currentTrainer.PhoneNumber,

            };

            await context.Trainers.AddAsync(trainer);
            await context.SaveChangesAsync();


        }
       
        public async Task DeleteAppliersAsync(Guid id)
        {
           
                var currentApplier = await context.Applies
                    .FirstOrDefaultAsync(x => x.Id == id);

                if (currentApplier == null)
                {
                    throw new NullReferenceException();
                }

            context.Applies.RemoveRange(currentApplier);
            await context.SaveChangesAsync();
            
        }      
        public async Task<IEnumerable<TrainerQuitViewModel>> GetAllAppliesAsync()
        {

            
             var applies = await context.Applies             
              .Select(x => new TrainerQuitViewModel()
              {

                  Id = x.Id,
                  Name = x.Name,
                  PhoneNumber = x.PhoneNumber,
                  Practis = x.Practis,
                  PricePerHour = x.PricePerHour,     
                  ForApplication = x.ForApplication,

              })
              .ToListAsync();

            return applies;
        }
    }
}
