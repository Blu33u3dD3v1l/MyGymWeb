using System.ComponentModel.DataAnnotations;

namespace MyGymWeb.Views.Home
{
    public class IndexModelDto
    {
        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Subject { get; set; } = null!;

        [Required]
        public string Message { get; set; } = null!;
    }
}
