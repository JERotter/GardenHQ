using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.RequestDtos;
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
    //    await _dbContext.SaveChangesAsync();
    //    return new BaseResponseDto { Message = "New task populated", Success = true };

    //}

    public async Task<BaseResponseDto> CreateTask(NewTaskRequestDto taskRequestDto)
    {
        var newTask = _mapper.Map<User>(taskRequestDto);

        await _dbContext.AddAsync(newTask);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "New task created", Success = true };
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


    //public async Task<BaseResponseDto<IEnumerable<UsersListResponseDto>>> GetUsers()
    //{
    //    var dbUsers = _dbContext.Set<User>()
    //        .Select(u => _mapper.Map<UsersListResponseDto>(u));

    //    if (dbUsers == null)
    //    {
    //        return new BaseResponseDto<IEnumerable<UsersListResponseDto>> { Message = "No users found", Success = false };
    //    }

    //    return new BaseResponseDto<IEnumerable<UsersListResponseDto>> { Message = "Users found", Success = true, Data = dbUsers };
    //}

    //public async Task<BaseResponseDto> UpdateUser(Guid userId, NewUserRequestDto UserRequestDto)
    //{
    //    var dbUser = _dbContext.Set<User>().SingleOrDefault(u => u.Id == userId);

    //    if (dbUser == null)
    //    {
    //        return new BaseResponseDto { Message = $"User with id #{userId} does not exist.", Success = false };
    //    }

    //    _mapper.Map(UserRequestDto, dbUser);
    //    await _dbContext.SaveChangesAsync();

    //    return new BaseResponseDto { Message = "User information updated.", Success = true };
    //}

    //public async Task<BaseResponseDto> DeleteUser(Guid userId)
    //{
    //    var dbUser = _dbContext.Set<User>().SingleOrDefault(u => u.Id == userId);

    //    if (dbUser == null)
    //    {
    //        return new BaseResponseDto { Message = $"User with id #{userId} does not exist.", Success = false };
    //    }

    //    _dbContext.Remove(dbUser);
    //    await _dbContext.SaveChangesAsync();

    //    return new BaseResponseDto { Message = "User has been deleted.", Success = true };
    //}
}