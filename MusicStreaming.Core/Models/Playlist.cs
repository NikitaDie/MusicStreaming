using System;
using System.Collections.Generic;

namespace MusicStreaming.Core.Models;

public class Playlist
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public Guid UserId { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual ICollection<Song> Songs { get; set; } = new List<Song>();

    public virtual ICollection<Song> SongsNavigation { get; set; } = new List<Song>();
}
