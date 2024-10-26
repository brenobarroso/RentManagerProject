using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Persons;

namespace Models.Properties
{
    public class Property
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string? Address { get; set; }

        [Range(0, double.MaxValue)]
        public double BuiltArea { get; set; }

        [Range(0, double.MaxValue)]
        public double TotalArea { get; set; }

        [Required]
        public PropertyType Type { get; set; }

        [Required]
        public PropertyUsage Usage { get; set; }

        [Required]
        public int LessorId { get; set; }
        [ForeignKey("LessorId")]
        public Person? Lessor { get; set; }

        public int? CurrentLesseeId { get; set; }
        [ForeignKey("CurrentLesseeId")]
        public Person? CurrentLessee { get; set; }

        [Range(0, double.MaxValue)]
        public decimal MonthlyRent { get; set; }

        public List<Person> PreviousLessees { get; set; } = new List<Person>();

        public DateTime? LastRentedDate { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        public bool IsCurrentlyRented => CurrentLessee != null;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }

    public enum PropertyType
    {
        House,          // Casa
        Apartment,      // Apartamento
        RuralProperty   // Propriedade Rural
    }

    public enum PropertyUsage
    {
        Commercial,     // Comercial
        Residential,    // Residencial
        Industrial      // Industrial
    }
}
