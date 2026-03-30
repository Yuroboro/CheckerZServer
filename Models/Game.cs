using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CheckerZ_Server.Models;

public partial class Game
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    public DateTime? GameDate { get; set; } = default(DateTime?);

    public int? Duration { get; set; } = null;

    public string? GameOutcome { get; set; } = null;

    [JsonIgnore]
    public virtual Player? Player { get; set; }
}
