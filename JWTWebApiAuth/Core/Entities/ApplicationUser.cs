using Microsoft.AspNetCore.Identity;

namespace JWTWebApiAuth.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
