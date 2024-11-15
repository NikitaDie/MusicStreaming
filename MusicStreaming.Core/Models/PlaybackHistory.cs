using System;
using System.Collections.Generic;

namespace MusicStreaming.Core.Models;

public class PlaybackHistory
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid SongId { get; set; }

    public DateTime? PlayedAt { get; set; }

    public virtual Song Song { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
