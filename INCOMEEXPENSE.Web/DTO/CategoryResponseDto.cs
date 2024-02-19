using System.ComponentModel.DataAnnotations;

namespace INCOMEEXPENSE.Web.DTO
{
    public class CategoryResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

    }
}
