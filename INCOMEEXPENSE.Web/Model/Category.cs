using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace INCOMEEXPENSE.Web.Model
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be between 1 and 50 characters", MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [RegularExpression("^(income|expense)$", ErrorMessage = "Type must be either 'income' or 'expense'")]
        public string Type { get; set; }

        [ForeignKey("User")]
        public Guid CreatedBy { get; set; }
        public Register User { get; set; }
 
    }
}
