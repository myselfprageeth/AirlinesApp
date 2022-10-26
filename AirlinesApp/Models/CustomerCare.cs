using System.ComponentModel.DataAnnotations.Schema;

namespace AirlinesApp.Models
{
    [Table("CustomerCare")]
    public class CustomerCare
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public long PhoneNumber { get; set; }
    }
}
