using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface ITrainerService
    {

        Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync();
        Task<TrainerViewModel> GetTrainerDescriptionAsync(Guid trainerId);
        Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId);
        Task<EditTrainerFormModel> GetEditTrainerAsync(Guid id);
        Task EditByIdAsync(Guid id, EditTrainerFormModel model);
        Task AddTrainerAsync(AddTrainerFormModel model);
        Task<bool> TrainerExistByUserId(string userId);
        Task BecomeTrainerAsync(string userId, AddTrainerFormModel model);


    }
}
