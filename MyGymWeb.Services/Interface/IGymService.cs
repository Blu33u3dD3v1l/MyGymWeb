using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IGymService
    {
        Task<IEnumerable<GymsViewModel>> GetAllGymsAsync();
        Task<GymsViewModel> GetDescriptionAsync(int gymId);
    }
}
