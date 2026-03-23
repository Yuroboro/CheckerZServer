using System;
using System.Collections.Generic;

namespace CheckerZ_Server.Models;

public partial class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual ICollection<Game> Games { get; set; } = new List<Game>();
}
