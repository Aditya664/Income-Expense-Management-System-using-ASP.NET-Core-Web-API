using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.DTO
{
    public class RegisterRequestDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string MobileNo { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
