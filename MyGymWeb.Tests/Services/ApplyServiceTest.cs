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


            //Arrange
            const string userId = "My UserId";

            using var data = DatabaseMock.Instance;          
            await data.Applies.AddAsync(new Apply { UserId = userId, ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Moto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

         

            var result = await applyService.ApplierExistByUserId(userId);

          
            Assert.True(result);
          

           
            
        }
        [Fact]
        public async void ApplierExistByUserIdReturnIncorrectValue()
        {

            using var data = DatabaseMock.Instance;
            await data.Applies.AddAsync(new Apply { UserId =  "UserId", ImageUrl = "1", Info = "Info", Name = "Name", Practis = "Practis", Type = "Type", Moto = "Moto" });
            await data.SaveChangesAsync();
            var applyService = new ApplyService(data);

            var result = await applyService.ApplierExistByUserId("Another UserId");

            Assert.False(result);




        }
    }
}
