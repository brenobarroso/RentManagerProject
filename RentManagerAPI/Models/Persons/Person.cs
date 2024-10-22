using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Models.Properties;

namespace Models.Persons
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
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [StringLength(300)]
        public string? Address { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        [Required]
        public PersonType PersonType { get; set; }

        // Relacionamentos
        public List<Property> OwnedProperties { get; set; } = new List<Property>();

        public Property? RentedProperty { get; set; }
    }

    public enum PersonType
    {
        Lessor,
        Lessee
    }
}
