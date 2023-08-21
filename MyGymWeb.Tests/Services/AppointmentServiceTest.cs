using Moq;
using MyGymWeb.Data.Models;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;

namespace MyGymWeb.Tests.Services
{
    public class AppointmentServiceTest
    {
        [Fact]

        public async void ApproveAppointmentShouldReturnRightValues()
        {

            int appId = 5;

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = appId,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),
            });
            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var result = appointmentService.ApproveAppointmentAsync(appId);

            var a = data.Appointments.FirstOrDefault(x => x.Id == appId);

            Assert.Equal(a?.Id, appId);

        }

        [Fact]
        public async void ApproveAppointmentShouldReturnWrongValues()
        {

            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = 2,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),
            });
            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var result = appointmentService.ApproveAppointmentAsync(appId);

            var a = data.Appointments.FirstOrDefault(x => x.Id == appId);

            Assert.NotEqual(a?.Id, appId);

        }

        [Fact]
        public async void DeleteAppointmentAsyncShouldReturnCorrectId()
        {

            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = appId,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),
            });
            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var a = data.Appointments.FirstOrDefault(x => x.Id == appId);

            Assert.NotNull(a);

            var result = appointmentService.DeleteAppointmentsAsync(appId);

            var b = data.Appointments.FirstOrDefault(x => x.Id == appId);

            Assert.Null(b);

        }

        [Fact]
        public async void DeleteAppointmentAsyncShouldReturnIncorrectId()
        {
            int appId = 1;

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = 2,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),
            });
            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

           var result = appointmentService.DeleteAppointmentsAsync(appId);

           await Assert.ThrowsAsync<NullReferenceException>(() => result);

        }

        [Fact]
        public async void GetAllAsyncShouldReturnCorrectView()
        {
            

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = 1,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),

            });
            
            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var result = await appointmentService.GetAllAsync();

            Assert.Single(result);
        }

        [Fact]
        public async void GetAllAsyncShouldNotReturnViews()
        {

            using var data = DatabaseMock.Instance;

            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var result = await appointmentService.GetAllAsync();
            var count = result.Count();

            Assert.True(count == 0);

        }

        [Fact]
        public async void GetAllAsyncShouldReturnMoreThanOneView()
        {

            using var data = DatabaseMock.Instance;
            await data.Appointments.AddAsync(new Appointment
            {
                Id = 1,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Ivan Ivanov",
                Email = "Ivan@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),

            });
            await data.Appointments.AddAsync(new Appointment
            {
                Id = 2,
                AppointmentTime = DateTime.UtcNow,
                ClientFullName = "Gosho Ivanov",
                Email = "Gosho@abv.bg",
                TrainerName = "Mike Tyson",
                TrainerId = Guid.NewGuid(),

            });

            await data.SaveChangesAsync();
            var appointmentService = new AppointmentService(data);

            var result = await appointmentService.GetAllAsync();

            var count = result.Count();

            Assert.True(count > 1);

        }

    }
}
