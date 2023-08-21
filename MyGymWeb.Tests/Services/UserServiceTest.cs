using MyGymWeb.Data.Models;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;


namespace MyGymWeb.Tests.Services
{
    public class UserServiceTest
    {

        [Fact]
        public async void AppointmentExistByUserIdShouldThrowException()
        {
            using var data = DatabaseMock.Instance;

            string userId = "UserId";
            Guid trainerId = Guid.NewGuid();

            var userTrainer = new UserTrainer()
            {
                TrainerId = trainerId,
                UserId = userId
            };

            await data.UsersTrainers.AddAsync(userTrainer);
            await data.SaveChangesAsync();
            var userService = new UserService(data);

            var result = userService.AppointmentExistByUserId(userId, trainerId);

            await Assert.ThrowsAsync<Exception>(() => result);
        }

        [Fact]
        public async void AppointmentExistByUserIdShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            string userId = "UserId";
            Guid trainerId = Guid.NewGuid();

            var userTrainer = new UserTrainer()
            {
                TrainerId = trainerId,
                UserId = "otherUserId"
            };

            await data.UsersTrainers.AddAsync(userTrainer);
            await data.SaveChangesAsync();
            var userService = new UserService(data);

            var result = await userService.AppointmentExistByUserId(userId, trainerId);

            Assert.False(result);
        }

        [Fact]
        public async void BuyProductAsyncShoudReturnCorrectValue()
        {

            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId
                
            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.BuyProductAsync(productId, userId);

            Assert.NotNull(result);

        }

        [Fact]
        public async void BuyProductAsyncAmountShouldTrowException()
        {

            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser
            {
                Id = userId,
                Amount = 1000
            });
           
            await data.Products.AddAsync(new Product
            {
                Id = productId,
                Price = 1001,
                Description = "f",
                Mark = "M",
                ImageUrl = "Im",
                Name = "Test",
            });

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId

            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.BuyProductAsync(productId, userId);

            await Assert.ThrowsAsync<Exception>(() => result);

        }

        [Fact]
        public async void BuyProductAsyncAmountShouldReturnCorrectValue()
        {

            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser
            {
                Id = userId,
                Amount = 1000
            });

            await data.Products.AddAsync(new Product
            {
                Id = productId,
                Price = 100,
                Description = "f",
                Mark = "M",
                ImageUrl = "Im",
                Name = "Test",
            });

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId

            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result =  userService.BuyProductAsync(productId, userId);

            Assert.NotNull(result);

        }

        [Fact]
        public async void CancelUserApplicationAsyncShouldReturnCorrectValues()
        {

            using var data = DatabaseMock.Instance;

            int id = 1;

            await data.Appointments.AddAsync(new Appointment 
            { 

                Id = id,
                ClientFullName = "Test",
                Email = "Test",
                TrainerName = "Test",
            
            });
            await data.SaveChangesAsync();
            var userService = new UserService(data);

            var result = userService.CancelUserApplicationAsync(id);

            Assert.NotNull(result); 

        }

        [Fact]
        public async void CancelUserApplicationAsyncShouldThrowException()
        {

            using var data = DatabaseMock.Instance;

            int id = 1;

            await data.Appointments.AddAsync(new Appointment
            {

                Id = 2,
                ClientFullName = "Test",
                Email = "Test",
                TrainerName = "Test",

            });
            await data.SaveChangesAsync();
            var userService = new UserService(data);

            var result = userService.CancelUserApplicationAsync(id);

            await Assert.ThrowsAsync<Exception>(() => result);

        }

        [Fact]
        public async void GetAllMyTrainersAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser { Id = userId, UserName = "Test" });
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.GetAllMyTrainersAsync(userId);

            Assert.NotNull(result);
        }

        [Fact]
        public async void GetAllMyTrainersAsyncShouldThrowException()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser { Id = "anotherId", UserName = "Test" });
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.GetAllMyTrainersAsync(userId);

            await Assert.ThrowsAsync<ArgumentException>(() => result);
        }

        [Fact]
        public async void GetAllProductsForBuyAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser { Id = userId, UserName = "Test" });
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.GetAllProductsForBuyAsync(userId);

            Assert.NotNull(result);


        }

        [Fact]
        public async void GetAllProductsForBuyAsyncShouldThrowException()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser { Id = "anotherId", UserName = "Test" });
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.GetAllProductsForBuyAsync(userId);

            await Assert.ThrowsAsync<ArgumentException>(() => result);
        }

        [Fact]
        public async void GetMyTrainersAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;


            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser { Id = userId, UserName = "Test" });
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.GetMyTrainersAsync(userId);

            Assert.NotNull(result);

        }

        [Fact]
        public async void ReturnProductAsyncShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser
            {
                Id = userId,
                Amount = 1000
            });

            await data.Products.AddAsync(new Product
            {
                Id = productId,
                Price = 100,
                Description = "f",
                Mark = "M",
                ImageUrl = "Im",
                Name = "Test",
            });

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId

            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.ReturnProductAsync(userId, productId);

            Assert.NotNull(result);

        }

        [Fact]
        public async void ReturnProductAsyncShouldTrowExceptionWhenUserIdIsNull()
        {
            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser
            {
                Id = "AnotherID",
                Amount = 1000
            });

            await data.Products.AddAsync(new Product
            {
                Id = productId,
                Price = 100,
                Description = "f",
                Mark = "M",
                ImageUrl = "Im",
                Name = "Test",
            });

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId

            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.ReturnProductAsync(userId, productId);

            await Assert.ThrowsAsync<ArgumentException>(() => result);
        }

        [Fact]
        public async void ReturnProductAsyncShouldTrowExceptionWhenProductIdIsNull()
        {
            using var data = DatabaseMock.Instance;

            int productId = 1;
            var userId = "UserId";

            await data.Users.AddAsync(new ApplicationUser
            {
                Id = userId,
                Amount = 1000
            });

            await data.Products.AddAsync(new Product
            {
                Id = 2,
                Price = 100,
                Description = "f",
                Mark = "M",
                ImageUrl = "Im",
                Name = "Test",
            });

            var userProduct = new UserProduct()
            {
                ProductId = productId,
                UserId = userId

            };

            await data.UsersProducts.AddRangeAsync(userProduct);
            await data.SaveChangesAsync();

            var userService = new UserService(data);

            var result = userService.ReturnProductAsync(userId, productId);

            await Assert.ThrowsAsync<ArgumentException>(() => result);
        }

        [Fact]
        public void UserFullNameShouldReturnCorrectValue()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            data.Users.AddRange(new ApplicationUser { Id = userId});
            data.SaveChanges();

            var userService = new UserService(data);

            var result = userService.UserFullName(userId);

            Assert.NotNull(result);
        }

        [Fact]
        public void UserFullNameShouldReturnNull()
        {
            using var data = DatabaseMock.Instance;

            var userId = "UserId";

            data.Users.Add(new ApplicationUser { Id = "AnotherId" });
            data.SaveChanges();

            var userService = new UserService(data);

            var result = userService.UserFullName(userId);

            Assert.ThrowsAsync<NullReferenceException>(() => result);

        }
    }
}
