using System;
using System.Collections.Generic;

namespace CheckerZ_Server.Models;

public partial class Game
{
    public int Id { get; set; }

    public int PlayerId { get; set; }

    public DateTime GameDate { get; set; }

    public int? Duration { get; set; }

    public string? Result { get; set; }

    public virtual Player Player { get; set; } = null!;
}
