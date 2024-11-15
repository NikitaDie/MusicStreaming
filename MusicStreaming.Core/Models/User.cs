using System;
using System.Collections.Generic;

namespace MusicStreaming.Core.Models;

public class User
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; } = new List<PlaybackHistory>();

    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();
}
