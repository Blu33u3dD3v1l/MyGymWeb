namespace MyGymWeb.Data.Models
{
  
    public class UserProduct
    {
      
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        public int ProductId { get; set; }

        public Product Product { get; set; } = null!;

        public decimal TotalCost { get; set; }

        public string? PromoCode { get; set; }

        
    }
}
