using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.DTO
{
    public class AccountResponseDto
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; } = "Untitled";
        public string AccountType { get; set; }
        public double InitialAmount { get; set; } = 0;
    }
}
