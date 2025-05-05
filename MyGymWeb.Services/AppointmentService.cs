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
        private readonly IEmailService emailService;
        

        public AppointmentService(MyGymProjectDbContext data, IEmailService emailService)
        {
            this.data = data;
            this.emailService = emailService;
           
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

            if (currentUser!.Amount - currentTrainer!.PricePerHour < 0)
            {
                throw new Exception("money is low");
            }
            if (!currentUser!.UsersTrainers.Any(m => m.TrainerId == ids!.TrainerId))
            {
                currentUser.UsersTrainers.Add(new UserTrainer()
                {
                    TrainerId = currentTrainer.Id,
                    UserId = currentUser.Id,
                    Trainer = currentTrainer,
                    User = currentUser
                });

                currentUser.Amount -= currentTrainer.PricePerHour;


            }
            else
            {
                throw new InvalidOperationException("Wrong user");
            }


            await data.SaveChangesAsync();

            await emailService.SendEmailAsync(currentUser.Email!, "Appointment Approved", $"Hello {currentUser.FirstName}, your appointment with {currentTrainer.Name} has been approved. The amount has been deducted from your account. Thank you!");

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
