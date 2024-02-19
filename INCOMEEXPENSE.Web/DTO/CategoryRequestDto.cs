using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.DTO
{
    public class CategoryRequestDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [RegularExpression("^(income|expense)$", ErrorMessage = "Type must be either 'income' or 'expense'")]
        public string Type { get; set; }
    }
}
