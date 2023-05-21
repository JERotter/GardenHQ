using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.EntityFrameworkCore;

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

    //public async Task<BaseResponseDto> PopulateTasks()
    //{
    //    var fakeUserId = new Guid();

    //    var dbTask = new GardenTask
    //    {
    //        Id = new Guid(),
    //        CreatedBy = new Guid(),
    //        LastUpdatedBy = new Guid(),
    //        CreatedOn = DateTime.UtcNow,
    //        LastUpdated = DateTime.UtcNow,
    //        Title = "Rake leaves",
    //        AssignedName = string.Empty,
    //        AssignedTo = Guid.Empty,
    //        Completed = false,
    //        priority = Priority.Moderate,

    //    };

    //    _dbContext.Add(dbTask);
    //    ASSIGN AbbreviatedId
    //    dbTask.AbbreviatedId = dbTask.Id.ToString().Substring(0, 4);
    //    await _dbContext.SaveChangesAsync();
    //    return new BaseResponseDto { Message = "New task populated", Success = true };

    //}


    //create task and set priority
    public async Task<BaseResponseDto> CreateTask(NewTaskRequestDto taskRequestDto)
    {
        var newTask = _mapper.Map<GardenTask>(taskRequestDto);

        await _dbContext.AddAsync(newTask);
        //ASSIGN AbbreviatedId
        newTask.AbbreviatedId = newTask.Id.ToString().Substring(0, 4);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "New task created", Success = true };
    }

    public async Task<BaseResponseDto<IEnumerable<TaskTableDto>>> GetTasks()
    {
        //var dbUsers = _dbContext.Set<User>()
        //    .Select(u => _mapper.Map<UsersListResponseDto>(u));

        var dbTasks = _dbContext.Set<GardenTask>()
            .Select(t => _mapper.Map<TaskTableDto>(t));

        if (dbTasks == null)
        {
            return new BaseResponseDto<IEnumerable<TaskTableDto>> { Message = "No tasks found", Success = false };
        }

        return new BaseResponseDto<IEnumerable<TaskTableDto>> { Message = "Tasks found", Success = true, Data = dbTasks };
    }

    //get task by id
    public async Task<BaseResponseDto<TaskDetailDto>> GetTaskDetail(Guid taskId)
    {
        var dbTask = await _dbContext.Set<GardenTask>()
            .Where(t => t.Id == taskId)
            .Select(t => _mapper.Map<TaskDetailDto>(t))
            .SingleOrDefaultAsync();

        if (dbTask == null)
        {
            return new BaseResponseDto<TaskDetailDto> { Message = "Not found", Success = false };
        }

        return new BaseResponseDto<TaskDetailDto> { Message = "Task found", Success = true, Data = dbTask };
    }

    //update task
    public async Task<BaseResponseDto> UpdateTask(Guid taskId, NewTaskRequestDto taskRequestDto)
    {
        var dbTask = _dbContext.Set<GardenTask>()
            .SingleOrDefault(t => t.Id == taskId);
           

        if (dbTask == null)
        {
            return new BaseResponseDto { Message = $"Task with id #{dbTask} does not exist.", Success = false };
        }

        _mapper.Map(taskRequestDto, dbTask);
        await _dbContext.SaveChangesAsync();

        return new BaseResponseDto { Message = "Task updated.", Success = true };
    }

    //delete tasks
    public async Task<BaseResponseDto> DeleteTask(Guid taskId)
    {
        var dbTask = _dbContext.Set<GardenTask>()
            .SingleOrDefault(t => t.Id == taskId);

        if (dbTask == null)
        {
            return new BaseResponseDto { Message = $"Task #{dbTask} does not exist.", Success = false };
        }

        _dbContext.Remove(dbTask);
        await _dbContext.SaveChangesAsync();

        return new BaseResponseDto { Message = "Task has been deleted.", Success = true };
    }


    //comment on task [volunteer, manager]
    //complete task [T/F]
    //assign tasks [manager, admin] by task id and user id
    //managers report to admin somehow, amybe a task report?

}