using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data;
using MyGymWeb.Data.Models;
using MyGymWeb.Models.Home;
using MyGymWeb.Services.Interface;

namespace MyGymWeb.Services
{
    public class AthleteService : IAthleteService
    {

        private readonly MyGymProjectDbContext context;

        public AthleteService(MyGymProjectDbContext _context)
        {
            context = _context;
        }

    }
}
