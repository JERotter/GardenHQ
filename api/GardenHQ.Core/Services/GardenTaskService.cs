using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;

namespace GardenHQ.Core.Services;

public class GardenTaskService
{
    private GardenDbContext _dbContext;
    private readonly IMapper _mapper;

    public GardenTaskService(GardenDbContext dbContext, IMapper mapper)
	{
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<BaseResponseDto> PopulateUsers()
    {
        var fakeUserId = new Guid();

        var dbTask = new GardenTask
        {
             AssignedName = null,
             AssignedTo = null,
           
        };

        _dbContext.Add(dbTask);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "New tasks added", Success = true };

    }
}


    
   