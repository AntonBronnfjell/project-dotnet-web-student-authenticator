using Microsoft.AspNetCore.Identity;

namespace AuthenticationSystem.Entities;

public class ApplicationUser : IdentityUser
{
    public bool IsDeveloper { get; set; } = false;
}