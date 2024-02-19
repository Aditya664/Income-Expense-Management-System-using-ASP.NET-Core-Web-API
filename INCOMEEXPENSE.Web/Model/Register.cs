using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.Model
{
    public class Register
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, ErrorMessage = "First name must be at most 50 characters.")]
        public string FirstName { get; set; }

        [StringLength(50, ErrorMessage = "Last name must be at most 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(100, ErrorMessage = "Email address must be at most 100 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required.")]
        [StringLength(12, ErrorMessage = "Mobile number must be at most 12 characters.")]
        public string MobileNo { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password must be at most 50 characters.")]
        public string Password { get; set; }
    }
}
