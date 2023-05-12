using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GardenHQ.Core.Services;

public class UsersService : IUsersService
{
    private GardenDbContext _dbContext;
    private readonly IMapper _mapper;

    public UsersService(GardenDbContext dbContext, IMapper mapper)
	{
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<BaseResponseDto> PopulateUsers()
    {
        var fakeUserId = new Guid();

        var dbUser = new User
        {
            //CreatedBy = fakeUser,
            //CreatedOn = DateTime.UtcNow,
            //DepartmentId = null,
            FirstName = "M.",
            LastName = "Stringer",
            //Email = "string@string",
            Type = UserType.Volunteer,
            Id = fakeUserId,
        };

        _dbContext.Add(dbUser);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "User added", Success = true };

    }

    public async Task<BaseResponseDto> CreateUser(NewUserRequestDto requestDto)
    {
        var newUser = _mapper.Map<User>(requestDto);

        await _dbContext.AddAsync(newUser);
        await _dbContext.SaveChangesAsync();
        return new BaseResponseDto { Message = "New user added", Success = true };
    }


    public async Task<BaseResponseDto<IEnumerable<UsersListResponseDto>>> GetUsers()
    {
        var dbUsers = _dbContext.Set<User>()
            .Select(u => _mapper.Map<UsersListResponseDto>(u));

        if (dbUsers == null)
        {
            return new BaseResponseDto<IEnumerable<UsersListResponseDto>> { Message = "No users found", Success = false };
        }

        return new BaseResponseDto<IEnumerable<UsersListResponseDto>> { Message = "Users found", Success = true, Data = dbUsers };
    }
}