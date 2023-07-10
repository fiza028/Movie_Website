using Microsoft.AspNetCore.Identity;

namespace Movieplayingwebsite.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
