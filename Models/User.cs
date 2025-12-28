using System.ComponentModel.DataAnnotations;

namespace FixIt.Models
{
    public enum UserRole
    {
        Customer = 0,
        Technician = 1,
        Admin = 2
    }

    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        public UserRole Role { get; set; } = UserRole.Customer;

        // İlişkiler
        public ICollection<RepairRequest>? RepairRequests { get; set; }
    }
}
