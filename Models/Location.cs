using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class Location
{
    public long LocationId { get; set; }

    public long UserId { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public byte[] Timestamp { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
