using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;


namespace MyGymWeb.Tests.Services
{
  
    public class ApplyServiceTest
    {
        [Fact]

        public async void ApplierExistByUserIdReturnCorrectValue()
        {

            const string userId = "My UserId";

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);



            var result = await applyService.ApplierExistByUserId(userId);

            Assert.True(result);

        }
        [Fact]
        public async void ApplierExistByUserIdReturnIncorrectValue()
        {

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = await applyService.ApplierExistByUserId("Another UserId");

            Assert.False(result);

        }

        [Fact]

        public void AddApplyShouldReturnCorrectId()
        {

            using var data = DatabaseMock.Instance;

            const string userId = "My UserId";

            var model = new TrainerQuitViewModel()
            {
                UserId = userId,
                ImageUrl = "1",
                Info = "Info",
                Name = "Name",
                Practis = "Practis",
                Type = "Type",
                Motto = "Moto"
            };

            var applyService = new ApplyService(data);

            var result = applyService.AddApplyAsync(userId, model);

            Assert.True(data.Applies.Count() != 0);
        }

        [Fact]
        public async void AddApplyShoulThrowExeption()
        {

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = await applyService.ApplierExistByUserId("Another UserId");

            Assert.False(result);

        }

        [Fact]

        public void AddApplyShouldReturnView()
        {

            using var data = DatabaseMock.Instance;
            var m = new TrainerQuitViewModel()
            {
                UserId = "UserId",
                Name = "Name",
                ImageUrl = "1",
                Info = "Info",
                Practis = "Practis",
                Type = "Type",
                Motto = "Moto"
            };

            var applyService = new ApplyService(data);

            var result = applyService.AddApplyAsync("UserId", m);

            Assert.NotNull(result);

        }

        [Fact]

        public async void ApplierExistByUserIdShouldExist()
        {

            const string userId = "My UserId";

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = await applyService.ApplierExistByUserId(userId);

            Assert.True(result);

        }
        [Fact]
        public async void ApplierExistByUserIdDidntExist()
        {

            const string userId = "My UserId";

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = await applyService.ApplierExistByUserId("Another Id");

            Assert.False(result);

        }

        [Fact]

        public async void DeleteApplierAsyncShouldReturnCorrectGuid()
        {
            Guid guid = Guid.NewGuid();

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = guid });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = applyService.DeleteAppliersAsync(guid);

            var a = data.Applies.FirstOrDefault(x => x.Id == guid);

            Assert.Null(a);

        }

        [Fact]

        public async void DeleteApplierAsyncThrowsExeption()
        {
            Guid guid = Guid.NewGuid();
            var guid2 = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00");

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = guid2 });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = applyService.DeleteAppliersAsync(guid);

            await Assert.ThrowsAsync<NullReferenceException>(() => result);

        }

        [Fact]

        public async void GetAllAppliersAsyncShouldReturnValueIfExist()
        {

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = applyService.GetAllAppliesAsync();

            Assert.True(result.Result.Count() != 0);

        }

        [Fact]
        public void GetAllAppliersAsyncShouldBeEmpty()
        {

            using var data = DatabaseMock.Instance;
            var applyService = new ApplyService(data);

            var result = applyService.GetAllAppliesAsync();

            Assert.True(result.Result.Count() == 0);

        }

        [Fact]
        public async void ApproveTrainerAsyncShouldReturnCorrectGuid()
        {

            Guid guid = Guid.NewGuid();

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = guid });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = applyService.ApproveTrainerAsync(guid);

            var a = data.Trainers.FirstOrDefault(x => x.Id == guid);

            Assert.NotNull(a);

        }

        [Fact]

        public async void ApproveTrainerShouldThrowException()
        {

            Guid guid = Guid.NewGuid();
            Guid guid2 = Guid.Parse("11223344-5566-7788-99AA-BBCCDDEEFF00");

            using var data = DatabaseMock.Instance;
            await data.Trainers.AddAsync(new Trainer { UserId = "userId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Motto = "Moto", Id = guid2 });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = applyService.ApproveTrainerAsync(guid);

            await Assert.ThrowsAsync<Exception>(() => result);
        }

       

      

    }
}
