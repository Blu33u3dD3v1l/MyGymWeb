namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>
    public class TrainerDetailsRemoveViewModel
    {
       
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Info { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}
