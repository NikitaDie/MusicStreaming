﻿namespace Cinema.Core.DTOs.Auditorium;

public class AuditoriumDetailedDto
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid BranchId { get; set; }
    
    public List<GetSeatDto> Seats { get; set; } = [];
}