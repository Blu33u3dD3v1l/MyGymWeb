using Microsoft.AspNetCore.Mvc;
using MyGymWeb.Services.Interface;


namespace MyGymWeb.Controllers
{
    public class AthleteController : Controller
    {
        private readonly IAthleteService athleteService;

        public AthleteController(IAthleteService _athleteService)
        {
            athleteService = _athleteService;
        }

 
    }
}
