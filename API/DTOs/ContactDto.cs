using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class ContactDto
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }
}