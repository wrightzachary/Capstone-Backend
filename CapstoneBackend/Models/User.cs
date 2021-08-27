using Microsoft.AspNetCore.Identity;

namespace CapstoneBackend.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DutyStation { get; set; }
        public string Unit { get; set; }
        public string BranchServed { get; set; }
        public string CurrentLocation { get; set; } 
    }
}
