using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;

namespace GardenHQ.Core.Services;

public class GardenTaskService : IGardenTaskService
{
    private GardenDbContext _dbContext;
    private readonly IMapper _mapper;

    public GardenTaskService(GardenDbContext dbContext, IMapper mapper)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<BaseResponseDto> PopulateTasks()
    {
        var fakeUserId = new Guid();

        var dbTask = new GardenTask
        {
            Id = new Guid(),
            CreatedBy = new Guid(),
            LastUpdatedBy = new Guid(),
            CreatedOn = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow,
            Title = "Rake leaves",
            AssignedName = string.Empty,
            AssignedTo = Guid.Empty,
            Completed = false,
            priority = Priority.Moderate,

        };

        _dbContext.Add(dbTask);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "New task added", Success = true };

    }

    //get all available tasks
    //get task by id
    //create task and set priority
    //delete tasks
    //comment on task [volunteer, manager]
    //update tasks
    //complete task [T/F]
    //assign tasks [manager, admin] by task id and user id
    //managers report to admin somehow, amybe a task report?
}



