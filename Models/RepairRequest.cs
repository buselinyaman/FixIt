using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FixIt.Models
{
    public class RepairRequest
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string CustomerName { get; set; } = string.Empty;

        public RequestStatus Status { get; set; } = RequestStatus.Pending;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Precision(10, 2)]
        public decimal? Cost { get; set; }

        public string? StatusNote { get; set; }

        // Müşteri ilişkisi
        public int? CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public User? Customer { get; set; }

        // Teknisyen ilişkisi
        public int? TechnicianId { get; set; }
        [ForeignKey("TechnicianId")]
        public User? Technician { get; set; }

    }

    public enum RequestStatus
    {
        Pending = 0,
        Accepted = 1,
        Completed = 2
    }
}

