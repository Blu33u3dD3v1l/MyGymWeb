using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;

namespace MyGymWeb.Tests.Mocks
{
    public static class DatabaseMock
    {
        public static MyGymProjectDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<MyGymProjectDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new MyGymProjectDbContext(dbContextOptions);
            }
        }

    }
}
