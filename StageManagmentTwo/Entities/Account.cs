using System.ComponentModel.DataAnnotations;

namespace StageManagmentTwo.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string HashPassword { get; set; }
    }
}
