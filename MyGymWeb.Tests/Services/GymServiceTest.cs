using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services;
using MyGymWeb.Tests.Mocks;

namespace MyGymWeb.Tests.Services
{
    public class GymServiceTest
    {

        [Fact]
        public void AddGymAsyncReturnCorrectValue()
        {

            using var data = DatabaseMock.Instance;

            AddGymFormModel a = new AddGymFormModel { Description = "des", ImageUrl = "image", Name = "Name" };
           
            var gymService = new GymService(data);

            var result =  gymService.AddGymAsync(a);

            Assert.NotNull(result);

        }

    }
}
