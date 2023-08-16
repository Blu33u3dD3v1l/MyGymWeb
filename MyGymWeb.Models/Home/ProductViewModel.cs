namespace MyGymWeb.Models.Home
{

    public class ProductViewModel
    {

      
        public int Id { get; set; }

        
        public string Mark { get; set; } = null!;

      
        public string Name { get; set; } = null!;

       
        public decimal Price { get; set; }

       
        public string Description { get; set; } = null!;

       
        public string ImageUrl { get; set; } = null!;

        public int ProductCount { get; set; }

        
    }
}
