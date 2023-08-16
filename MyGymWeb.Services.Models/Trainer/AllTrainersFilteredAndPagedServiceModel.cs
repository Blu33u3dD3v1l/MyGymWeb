using MyGymWeb.Models.Home;

namespace MyGymWeb.Services.Models.Trainer
{
    public class AllTrainersFilteredAndPagedServiceModel
    {

        public AllTrainersFilteredAndPagedServiceModel()
        {
            this.Trainers = new HashSet<AllTrainersViewModel>();
        }


        public int TotalTrainersCount { get; set; }

        public IEnumerable<AllTrainersViewModel> Trainers { get; set; }
    }
}
