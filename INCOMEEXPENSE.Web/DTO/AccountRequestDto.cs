using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.DTO
{
    public class AccountRequestDto
    {
        [Required(ErrorMessage = "Account Name is required")]
        [StringLength(50, ErrorMessage = "Account Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string AccountName { get; set; } = "Untitled";

        [Required(ErrorMessage = "Type is required")]
        [RegularExpression("^(income|expense|common)$", ErrorMessage = "Type must be either 'income' , 'expense' 'common'")]
        public string AccountType { get; set; }
        public double InitialAmount { get; set; } = 0;

    }
}
