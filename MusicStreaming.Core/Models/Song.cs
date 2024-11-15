using System;
using System.Collections.Generic;

namespace MusicStreaming.Core.Models;

public class Song
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Artist { get; set; } = null!;

    public string? Album { get; set; }

    public TimeSpan Duration { get; set; }

    public string? Genre { get; set; }

    public string Url { get; set; } = null!;

    public virtual ICollection<PlaybackHistory> PlaybackHistories { get; set; } = new List<PlaybackHistory>();

    public virtual ICollection<Playlist> Playlists { get; set; } = new List<Playlist>();

    public virtual ICollection<Playlist> Users { get; set; } = new List<Playlist>();
}
