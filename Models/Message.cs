using System;
using System.Collections.Generic;

namespace LonelyForU.Models;

public partial class Message
{
    public long MessageId { get; set; }

    public long SenderUserId { get; set; }

    public long RecipientUserId { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public string MessageContent { get; set; } = null!;

    public virtual User RecipientUser { get; set; } = null!;

    public virtual User SenderUser { get; set; } = null!;
}
