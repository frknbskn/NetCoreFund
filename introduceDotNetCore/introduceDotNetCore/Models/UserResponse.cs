using System.ComponentModel.DataAnnotations;

namespace introduceDotNetCore.Models
{
    public class UserResponse
    {
        [Required(ErrorMessage = "İsim zorunludur.")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Eposta formatı doğru değildir, type=email")]
        public string Email { get; set; }
        public bool IsApproved { get; set; }
    }
}
