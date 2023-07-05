using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class UserProfile
{
    public long ProfileId { get; set; }

    public long UserId { get; set; }

    public long GenderId { get; set; }

    public DateTime Dob { get; set; }

    public string? Bio { get; set; }

    public string? ProfilePic { get; set; }

    public virtual User User { get; set; } = null!;
}
