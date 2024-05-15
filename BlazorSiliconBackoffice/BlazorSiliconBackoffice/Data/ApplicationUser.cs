using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BlazorSiliconBackoffice.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public string? ProfileImageUrl { get; set; }
        public string? Bio { get; set; }
        public bool CodeVerified { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        public bool DarkmodeActive { get; set; } = false;
        public string? AddressId { get; set; }
        public bool IsSubscribed {  get; set; } = false;
    }
}
