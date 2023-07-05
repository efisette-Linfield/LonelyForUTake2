using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class User
{
    public long UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime JoinDate { get; set; }

    public string? LastName { get; set; }

    public byte? Age { get; set; }

    public virtual ICollection<Like> LikeRecipientUsers { get; set; } = new List<Like>();

    public virtual ICollection<Like> LikeSenderUsers { get; set; } = new List<Like>();

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<Message> MessageRecipientUsers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageSenderUsers { get; set; } = new List<Message>();

    public virtual ICollection<UserGender> UserGenders { get; set; } = new List<UserGender>();

    public virtual ICollection<UserProfile> UserProfiles { get; set; } = new List<UserProfile>();
}
