﻿using MyGymWeb.Models.Home;
using MyGymWeb.Services.Models.Trainer;

namespace MyGymWeb.Services.Interface
{
    public interface ITrainerService
    {

        Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync();
        Task<TrainerViewModel> GetTrainerDescriptionAsync(Guid trainerId);
        Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId);
        Task<EditTrainerFormModel> GetEditTrainerAsync(Guid id);
        Task EditByIdAsync(Guid id, EditTrainerFormModel model);      
        Task<bool> TrainerExistByUserId(string userId);      
        Task<TrainerDetailsRemoveViewModel> GetForDeleteAsync(Guid id, TrainerDetailsRemoveViewModel model);
        Task<bool> GetTrainerUserId(Guid trainerId, string UserId);
        Task DeleteTrainerAsync(Guid id);
        Task AddTrainerAsync(AddTrainerFormModel model);       
        Task DeleteTrainerForApplyAsync(Guid id);
        Task<AllTrainersFilteredAndPagedServiceModel> AllAsync(AllTrainersQueryModel model);
        public void ReactToTrainer(Guid trainerId, string userId, bool isLike);
        public (int likes, int dislikes, bool? userReaction) GetReactions(Guid trainerId, string? userId);


    }
}
