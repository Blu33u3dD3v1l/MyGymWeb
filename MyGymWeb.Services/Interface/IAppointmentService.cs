using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Interface
{
    public interface IAppointmentService
    {
        Task<IEnumerable<UserTrainersFormModel>> GetAllAsync();
        Task ApproveAppointmentAsync(int id);
        Task DeleteAppointmentsAsync(int id);

    }
}
