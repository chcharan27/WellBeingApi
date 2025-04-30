using Microsoft.AspNetCore.Identity;

namespace CareConnect.Services.AuthApi.models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? BloodGroup { get; set; }
        public string? MaritalStatus { get; set; }
        public string? JobDescription { get; set; }
        public string Role { get; set; } = "User";

    }
}
