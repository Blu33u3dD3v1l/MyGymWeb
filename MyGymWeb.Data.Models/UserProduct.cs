namespace MyGymWeb.Data.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProduct
    {
      
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;
    }
}
