using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheckerZ_Server.Models;

public partial class Player
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [Display(Name = "ID (from 1 to 1000)")]
    [Required(ErrorMessage = "ID is required.")]
    [Range(1, 1000, ErrorMessage = "ID must be a number between 1 and 1000.")]
    public int Id { get; set; }

    [Display(Name = "Name")]
    [Required(ErrorMessage = "Name is required.")]
    [MinLength(2, ErrorMessage = "Name must contain at least 2 letters.")]
    public string? Name { get; set; } = default;

    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone number is required.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be exactly 10 digits.")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Country")]
    [Required(ErrorMessage = "Please select a country.")]
    public string? Country { get; set; }

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
