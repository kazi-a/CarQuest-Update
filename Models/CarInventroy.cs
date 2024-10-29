using System.ComponentModel.DataAnnotations;

namespace CarQuest.Models
{
    public class CarInventory
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter the make using 30 characters or less.")]
        public string? Make { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please enter the model using 30 characters or less.")]
        public string? Model { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int Year { get; set; }

        // Foreign Key
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } // Navigation property
    }
}
