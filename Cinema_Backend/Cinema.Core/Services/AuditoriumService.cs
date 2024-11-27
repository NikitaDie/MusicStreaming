﻿using AutoMapper;
using Cinema.Core.DTOs.Auditorium;
using Cinema.Core.Helpers.UnifiedResponse;
using Cinema.Core.Interfaces;
using Cinema.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Core.Services;

public class AuditoriumService : IAuditoriumService
{
    private readonly IRepository _repository;
    private readonly IMapper _mapper;
    
    public AuditoriumService(IRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<Result<AuditoriumDetailsDto>> GetAuditorium(Guid id)
    {
        var auditorium = await _repository.GetAll<Auditorium>()
            // .Where(a => !a.IsDeleted)
            .Include(a => a.Seats)
                .ThenInclude(seat => seat.Status)
            .FirstOrDefaultAsync(a => a.Id == id);

        if (auditorium == null)
        {
            return Result.Failure<AuditoriumDetailsDto>("Auditorium not found");
        }

        var auditoriumDto = _mapper.Map<AuditoriumDetailsDto>(auditorium);

        return Result.Success(auditoriumDto);
    }

    public async Task<Result<AuditoriumMinimalDto>> CreateAuditorium(CreateAuditoriumDto newAuditorium)
    {
        var auditorium = _mapper.Map<Auditorium>(newAuditorium);
        await _repository.AddAsync(auditorium);
        await _repository.SaveChangesAsync();
        
        var auditoriumDto = _mapper.Map<AuditoriumMinimalDto>(auditorium);
        
        return Result.Success(auditoriumDto);
    }
}