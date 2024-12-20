﻿using System;
using System.Collections.Generic;
using Cinema.Core.Models.Helpers;

namespace Cinema.Core.Models;

public partial class Movie : SoftDelete
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;
    
    public string? OriginalTitle { get; set; }
    
    public int AgeRating { get; set; }
    
    public int ReleaseYear { get; set; }
    
    public string Director { get; set; }
    
    public DateOnly RentalPeriodStart { get; set; }
    
    public DateOnly RentalPeriodEnd { get; set; }
    
    public string Language { get; set; }

    public TimeSpan Duration { get; set; }
    
    public string? Producer { get; set; }
    
    public string? ProductionStudio { get; set; }
    
    public string? Screenplay { get; set; }
    
    public string? InclusiveAdaptation { get; set; }
    
    public string? Description { get; set; }

    public string TrailerLink { get; set; }
    
    public string ImagePath { get; set; }

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();
    
    public virtual ICollection<Actor> Starring { get; set; } = new List<Actor>();
    
    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
