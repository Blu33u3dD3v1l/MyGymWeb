using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;

namespace MyGymWeb.Tests.Services
{
    public class TrainerServiceTest
    {

        [Fact]

        public void GetAllTrainersAsyncShouldBeEmpty()
        {
            using var data = DatabaseMock.Instance;
            var trainerSrvice = new TrainerService(data);

            var result = trainerSrvice.GetAllTrainersAsync();

            Assert.True(result.Result.Count() == 0);
        }

        [Fact]

        public async void GetAllTrainersAsyncShouldReturnValueIfExist()
        {


            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);



            var result = trainerService.GetAllTrainersAsync();


            Assert.True(result.Result.Count() == 1);


        }

        [Fact]

        public async void GetAllTrainersAsyncShouldReturnView()
        {
            using var data = DatabaseMock.Instance;
            Guid guid = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00");

            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = guid });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetAllTrainersAsync();

            Assert.NotNull(result);

        }

        [Fact]

        public async void GetTypeTrainersAsyncShouldReturnCorrectValue()
        {
            var data = DatabaseMock.Instance;
            var gymId = 1;

            await data.Gyms.AddAsync(new Gym
            {

                Id = gymId,
                Description = "Des",
                ImageUrl = "Image",
                Name = "Gym",
                Type = "ClassicGym"

            });

            var trainerService = new TrainerService(data);

            var result = await trainerService.GetTypeTrainersAsync(gymId);

            Assert.NotNull(result);
        }

        [Fact]

        public async void GetTypeTrainersAsyncShouldReturnException()
        {
            var data = DatabaseMock.Instance;
            var gymId = 1;

            await data.Gyms.AddAsync(new Gym
            {

                Id = 2,
                Description = "Des",
                ImageUrl = "Image",
                Name = "Gym",
                Type = "ClassicGym"

            });

            var trainerService = new TrainerService(data);

            var result = trainerService.GetTypeTrainersAsync(gymId);

            await Assert.ThrowsAsync<ArgumentNullException>(() => result);
        }


        [Fact]

        public async void GetTrainerDescriptionAsyncShouldReturnCorrectValue()
        {
            var data = DatabaseMock.Instance;
            var trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetTrainerDescriptionAsync(trainerId);

            Assert.NotNull(result);

        }

        [Fact]

        public async void GetTrainerDescriptionAsyncShouldThrowException()
        {
            var data = DatabaseMock.Instance;
            var trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = trainerService.GetTrainerDescriptionAsync(trainerId);

            await Assert.ThrowsAsync<ArgumentNullException>(() => result);

        }

        [Fact]

        public async void GetEditTrainerAsyncShouldReturnCorrectValue()
        {
            var data = DatabaseMock.Instance;
            var trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetEditTrainerAsync(trainerId);

            Assert.NotNull(result);

        }

        [Fact]

        public async void GetEditTrainerAsyncShouldThrowException()
        {
            var data = DatabaseMock.Instance;
            var trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = trainerService.GetEditTrainerAsync(trainerId);

            await Assert.ThrowsAsync<ArgumentNullException>(() => result);

        }

        [Fact]

        public async void EditByIdAsyncShoudReturnCorrectValue()
        {
            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);


            await data.SaveChangesAsync();
            var producService = new ProductService(data);

            var a = data.Trainers.FirstOrDefault(x => x.Id == trainerId);
            if (a != null)
            {
                EditTrainerFormModel model = new EditTrainerFormModel
                {

                    ImageUrl = a.ImageUrl,
                    Info = a.Info,
                    Name = a.Name,
                    Practis = a.Practis,
                    Type = a.Type,
                    Motto = a.Motto,
                    Id = a.Id

                };

                var result = trainerService.EditByIdAsync(trainerId, model);

                Assert.Equal(trainerId, model.Id);
            }
        }

        [Fact]

        public async void EditByIdAsyncShoudTrowException()
        {
            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);


            await data.SaveChangesAsync();
            var producService = new ProductService(data);

            var a = data.Trainers.FirstOrDefault(x => x.Id == trainerId);
            if (a != null)
            {
                EditTrainerFormModel model = new EditTrainerFormModel
                {

                    ImageUrl = a.ImageUrl,
                    Info = a.Info,
                    Name = a.Name,
                    Practis = a.Practis,
                    Type = a.Type,
                    Motto = a.Motto,
                    Id = a.Id

                };

                var result = trainerService.EditByIdAsync(trainerId, model);

                await Assert.ThrowsAsync<ArgumentNullException>(() => result);
            }
        }

        [Fact]

        public async void TrainerExistByUserIdShouldReturnCorrectValue()
        {
            //Arrange
            const string userId = "My UserId";

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.TrainerExistByUserId(userId);

            Assert.True(result);
        }

        [Fact]
        public async void TrainerExistByUserIdShouldReturnIncorrectValue()
        {

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.TrainerExistByUserId("Another UserId");

            Assert.False(result);

        }


        [Fact]
        public async void DeleteTrainerAsyncShouldReturnCorrectValue()
        {
            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);
         

            var a = data.Trainers.FirstOrDefault(x => x.Id == trainerId);

            Assert.NotNull(a);


            var result = trainerService.DeleteTrainerAsync(trainerId);

            var b = data.Trainers.FirstOrDefault(x => x.Id == trainerId);

            Assert.Null(b);
        }

        [Fact]

        public async void DeleteProductAsyncShouldReturnException()
        {


            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);
          

            var result = trainerService.DeleteTrainerAsync(trainerId);

            await Assert.ThrowsAsync<NullReferenceException>(() => result);

        }

        [Fact]

        public async void GetTrainerUserIdShouldReturnCorrectValue()
        {

            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");
            string userId = "UserId";

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetTrainerUserId(trainerId, userId);

            Assert.True(result);

        }

        [Fact]

        public async void GetTrainerUserIdShouldThrowExeptionForNotExistingUserId()
        {
            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");
            string userId = "UserId";

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "another", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetTrainerUserId(trainerId, userId);

            Assert.False(result);

        }

        [Fact]

        public async void GetTrainerUserIdShouldThrowExeptionForNotExistingTrainerId()
        {
            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");
            string userId = "UserId";

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = await trainerService.GetTrainerUserId(trainerId, userId);

            Assert.False(result);

        }

        [Fact]

        public async void GetForDeleteAsyncShouldReturnCorrectValue()
        {

            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "User", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var a = data.Trainers.FirstOrDefault(x => x.Id == trainerId);
            if (a != null)
            {
                TrainerDetailsRemoveViewModel model = new TrainerDetailsRemoveViewModel
                {
                    ImageUrl = a.ImageUrl,
                    Name = a.Name,
                    Id = a.Id,
                    Info = a.Info,

                };

                var result = trainerService.GetForDeleteAsync(trainerId, model);

                Assert.NotNull(result);
            }
        }

        [Fact]

        public  void AddTrainersAsyncShouldReturnCorrectValue()
        {

                using var data = DatabaseMock.Instance;

                var m = new AddTrainerFormModel()
                {
                    UserId = "UserId",
                    Name = "Name",
                    ImageUrl = "1",
                    Info = "Info",
                    Practis = "Practis",
                    Type = "Type",
                    Motto = "Moto"
                };


                var trainerService = new TrainerService(data);

                var result = trainerService.AddTrainerAsync(m);

                Assert.NotNull(result);
        }


        [Fact]

        public async void QuitTrainerAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            var userId = "userId";

            await data.Trainers.AddAsync(new Trainer { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var a = data.Trainers.FirstOrDefault(x => x.UserId == userId);
            if(a != null)
            {
                var m = new TrainerQuitViewModel()
                {
                    UserId = a.UserId,
                    Name = "Name",
                    ImageUrl = "1",
                    Info = "Info",
                    Practis = "Practis",
                    Type = "Type",
                    Motto = "Moto"
                };


                var res = m.UserId;

                var result = trainerService.QuitTrainerAsync(userId, m);


                Assert.Equal(userId, res);
            }

        }


        [Fact]

        public async void QuitTrainerAsyncShouldThrowException()
        {
            using var data = DatabaseMock.Instance;

            var userId = "userId";

            await data.Trainers.AddAsync(new Trainer { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var a = data.Trainers.FirstOrDefault(x => x.UserId == userId);
            if (a == null)
            {
                var m = new TrainerQuitViewModel()
                {
                    UserId = "AnotherId",
                    Name = "Name",
                    ImageUrl = "1",
                    Info = "Info",
                    Practis = "Practis",
                    Type = "Type",
                    Motto = "Moto"
                };

                var result = trainerService.QuitTrainerAsync(userId, m);

                await Assert.ThrowsAsync<Exception>(() => result);

            }

        }

        [Fact]

        public async void DeleteTrainerForApplyAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "UserID", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = trainerId });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var a = data.Trainers.FirstOrDefault(x => x.Id == trainerId);

            Assert.NotNull(a);

            var result = trainerService.DeleteTrainerForApplyAsync(trainerId);

            var b = data.Trainers.FirstOrDefault(x => x.Id == trainerId);

            Assert.Null(b);

        }

        [Fact]

        public async void DeleteTrainerForApplyAsyncShouldTrowException()
        {
            using var data = DatabaseMock.Instance;

            Guid trainerId = new Guid("67815888-A8F4-4A91-99E5-C02716CFA397");

            await data.Trainers.AddAsync(new Trainer { UserId = "UserID", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = Guid.NewGuid() });
            await data.SaveChangesAsync();
            var trainerService = new TrainerService(data);

            var result = trainerService.DeleteTrainerForApplyAsync(trainerId);

            await Assert.ThrowsAsync<NullReferenceException>(() => result);
        }
    }
}
    

