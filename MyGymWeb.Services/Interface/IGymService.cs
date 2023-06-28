using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IGymService
    {
        Task<IEnumerable<GymsViewModel>> GetAllGymsAsync();
        Task<GymsViewModel> GetDescriptionAsync(int gymId);
        Task<IEnumerable<IndexViewModel>> GetAllGymsForIndexAsync();
        Task<IEnumerable<TrainerViewModel>> GetAllTrainersAsync();
        Task<TrainerViewModel> GetTrainerDescriptionAsync(int trainerId);
        Task<IEnumerable<ProductViewModel>> GetAllProductsAsync();
        Task<ProductViewModel> GetProductDescriptionAsync(int productId);

    }
}
