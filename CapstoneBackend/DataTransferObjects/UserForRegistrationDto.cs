using System.ComponentModel.DataAnnotations;

namespace CapstoneBackend.DataTransferObjects
{
    public class UserForRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
        public string Email { get; set; }
        public string DutyStation { get; set; }
        public string Unit { get; set; }
        public string BranchServed { get; set; }
        public string CurrentLocation { get; set; }
    }
}
