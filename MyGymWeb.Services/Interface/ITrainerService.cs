using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface ITrainerService
    {

        Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync();
        Task<TrainerViewModel> GetTrainerDescriptionAsync(int trainerId);
        Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId);
    }
}
