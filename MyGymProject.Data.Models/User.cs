namespace MyGymProject.Data.Models
{
    public class User
    {
        public virtual IList<GymUser> GymsUsers { get; set; } = new List<GymUser>();
    }
}
