using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly MyGymProjectDbContext data;

        public AppointmentService(MyGymProjectDbContext _data)
        {
            data = _data;
        }

        public async Task ApproveAppointmentAsync(int id)
        {


            var ids = await data.Appointments.FirstOrDefaultAsync(x => x.Id == id);

            var currentUser = await data.Users
                   .Where(u => u.Id == ids!.UserId)
                   .Include(x => x.UsersTrainers)
                   .FirstOrDefaultAsync();

            var currentTrainer = await data.Trainers
              .Where(u => u.Id == ids!.TrainerId)
              .FirstOrDefaultAsync();

            if (!currentUser!.UsersTrainers.Any(m => m.TrainerId == ids!.TrainerId && m.UserId == ids!.UserId))
            {
                currentUser.UsersTrainers.Add(new UserTrainer()
                {
                    TrainerId = currentTrainer!.Id,
                    UserId = currentUser.Id,
                    Trainer = currentTrainer,
                    User = currentUser
                });

            }
            else
            {
                throw new InvalidOperationException("Wrong user");
            }

            await data.SaveChangesAsync();
        }

        public async Task DeleteAppointmentsAsync(int id)
        {
            var currentApplier = await data.Appointments
                   .FirstOrDefaultAsync(x => x.Id == id);

            if (currentApplier == null)
            {
                throw new NullReferenceException();
            }

            data.Appointments.RemoveRange(currentApplier);
            await data.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserTrainersFormModel>> GetAllAsync()
        {
            var currenUser = await data.Users.FirstOrDefaultAsync();
            List<UserTrainersFormModel> result = new List<UserTrainersFormModel>();


            foreach (var item in data.Appointments)
            {
                var a = new UserTrainersFormModel()
                {
                    Id = item.Id,
                    AppointmentTime = item.AppointmentTime.ToString(),
                    ClientFullName = item.ClientFullName,
                    Email = item.Email,
                    TrainerName = item.TrainerName,
                    TrainerId = item.TrainerId,
                };

                result.Add(a);
            }

            return result;
        }

     
    }
}
