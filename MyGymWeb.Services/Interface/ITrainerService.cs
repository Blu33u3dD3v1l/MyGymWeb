using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface ITrainerService
    {

        Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync();
        Task<TrainerViewModel> GetTrainerDescriptionAsync(int trainerId);
        Task<IEnumerable<TrainerViewModel>> GetTypeTrainersAsync(int gymId);
        Task<EditTrainerFormModel> GetEditTrainerAsync(int id);
        Task EditByIdAsync(int id, EditTrainerFormModel model);

    }
}
