using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class Gender
{
    public long GenderId { get; set; }

    public string? SexType { get; set; }

    public virtual ICollection<UserGender> UserGenders { get; set; } = new List<UserGender>();
}
