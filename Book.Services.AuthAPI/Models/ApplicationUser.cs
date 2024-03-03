using Microsoft.AspNetCore.Identity;

namespace Book.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
