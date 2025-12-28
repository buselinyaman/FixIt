using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixIt.Models
{
    public class UserRefreshToken
    {
        public int Id { get; set; }

        public string Token { get; set; } = string.Empty;

        public DateTime ExpiryDate { get; set; }

        // User bağlantısı
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
    }
}
