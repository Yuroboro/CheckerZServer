using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CheckerZ_Server.Models;

public partial class Game
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    [Display(Name = "Date")]
    public DateTime? GameDate { get; set; } = default(DateTime?);

    [Display(Name = "Duration")]
    public int? Duration { get; set; } = null;

    [Display(Name = "Result")]
    public string? GameOutcome { get; set; } = null;

    [Display(Name = "Player")]
    [JsonIgnore]
    public virtual Player? Player { get; set; }
}
