using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class Like
{
    public long LikeId { get; set; }

    public long SenderUserId { get; set; }

    public long RecipientUserId { get; set; }

    public string LikeStatus { get; set; } = null!;

    public byte[] Timestamp { get; set; } = null!;

    public virtual User RecipientUser { get; set; } = null!;

    public virtual User SenderUser { get; set; } = null!;
}
