using System.Reflection;

namespace MyGymWeb.Models.Home
{
    /// <summary>
    /// 
    /// </summary>
    public class UserServiceModel
    {
        public string? UserId { get; init; } = null;

        public string Email { get; init; } = null!;

        public string FullName { get; init; } = null!;

        public string? PhoneNumber { get; init; } = null;



    }
}
