using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarQuest.Models
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    public class Customer
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string? FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Please enter your full name using 30 characters or less.")]
        public string? LastName { get; set; }

        [Display(Name = "Gender")]
        public Gender? GenderIdentity { get; set; }

        [StringLength(50, ErrorMessage = "Please enter your address using 50 characters or less.")]
        public string? Address { get; set; }

        [StringLength(30, ErrorMessage = "Please enter the city using 30 characters or less.")]
        public string? City { get; set; }

        [StringLength(2, ErrorMessage = "Please enter the state using 2 characters.")]
        public string? State { get; set; }

        [StringLength(10, ErrorMessage = "Zipcode has a maximum length of 10 numbers.")]
        public string? Zip { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Cell Phone")]
        public string? Cell { get; set; }

        // Navigation property for related car inventory
        public ICollection<CarInventory> CarInventories { get; set; } = new List<CarInventory>();
    }
}
