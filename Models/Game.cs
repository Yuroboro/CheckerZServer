using System;
using System.Collections.Generic;

namespace CheckerZ_Server.Models;

public partial class Game
{
    public int Id { get; set; }

    public int SessionID {  get; set; } 

    public int PlayerId { get; set; }

    public DateTime? GameDate { get; set; } = default(DateTime?);

    public int? Duration { get; set; } = null;

    public string? Result { get; set; } = null;

    public virtual Player Player { get; set; } = null!;
}
