using MyGymWeb.Models.Enums;


namespace MyGymWeb.Models.Home
{
    public class AllTrainersQueryModel
    {


        public AllTrainersQueryModel()
        {

                this.CurrentPage = 1;
                this.TrainersPerPage = 3;

                this.Trainers = new HashSet<AllTrainersViewModel>();
        }


        public string? SeachString { get; set; }
        
        public TrainerSorting TrainerSorting { get; set; }

        public int CurrentPage { get; set; }    

        public int TrainersPerPage { get; set; }

        public int TotalTrainers { get; set; }

        public  IEnumerable<AllTrainersViewModel> Trainers { get; set; }
    }
}
