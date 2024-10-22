using System;
using System.ComponentModel.DataAnnotations;

namespace SeuNamespace.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string? LastName { get; set; }

        [EmailAddress]
        [StringLength(200)]
        public string? Email { get; set; }

        [Phone]
        [StringLength(11)]
        public string? PhoneNumber { get; set; }

        [StringLength(300)]
        public string? Address { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdateAt { get; set; }

        [Required]
        public Role Role { get; set; }
    }

    public enum Role
    {
        Lessor, // Locador
        Lessee  // Locatário
    }
}
