using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class UserGender
{
    public long UserGenderId { get; set; }

    public long UserId { get; set; }

    public long GenderId { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
