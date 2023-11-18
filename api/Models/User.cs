using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(200)]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string? Role { get; set; }
    }
}
