using MyGymWeb.Data.Models;

namespace MyGymWeb.Models.Home
{

    public class DiscountViewModel
    {


        public int Id { get; set; }


        public string Mark { get; set; } = null!;


        public string Name { get; set; } = null!;


        public decimal Price { get; set; }


        public string Description { get; set; } = null!;


        public string ImageUrl { get; set; } = null!;

        public int ProductCount { get; set; }

        public decimal DiscountPrice { get; set; }

        public List<UserProduct> UserProduct { get; set; } = new List<UserProduct>();

    }
}
