using System.ComponentModel.DataAnnotations;

namespace Rad_Store.Model
{
    public class Contact
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Input Name Limit Exceeds", MinimumLength = 3)]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Message { get; set; }
        
    }
}
