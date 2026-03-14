using System.ComponentModel.DataAnnotations;

namespace CheckerZ_Server
{
    public class Player
    {
        [Required(ErrorMessage = "ID is required.")]
        [Range(1, 1000, ErrorMessage = "ID must be a number between 1 and 1000.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name must contain at least 2 letters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please select a country.")]
        public string Country { get; set; }
    }
}
