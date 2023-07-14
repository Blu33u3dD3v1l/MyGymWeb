using System.Security.Claims;


namespace MyGymWeb.Infrastructure.Extensions
{
    public static class ClaimsExtensions
    {

        public static string? GetId(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        } 
     
    }
}

