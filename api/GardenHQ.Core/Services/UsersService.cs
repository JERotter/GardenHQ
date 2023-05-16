using System;
using AutoMapper;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Mvc;
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

        var fakeAddress = new Address
        {
            Id = new Guid(),
            StreetAddress = "123 four st",
            StreetAddressLine2 = null,
            City = "CityTowneShire",
            Country = "United States",
            ZipCode = "12345",
            State = "HI",
            CreatedBy = new Guid(),
            LastUpdatedBy = new Guid(),
            CreatedOn = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow

        };

        var dbUser = new User
        {
            CreatedBy = fakeUserId,
            LastUpdatedBy = fakeUserId,
            LastUpdated = DateTime.UtcNow,
            CreatedOn = DateTime.UtcNow,
            FirstName = "M.",
            LastName = "Stringer",
            Email = "string@string",
            Address = fakeAddress,
            Phone = "(111) 555 - 5555",
            DateOfBirth = "5/9/1998",
            AssignedTasks = null,
            Type = UserType.Volunteer,
            Id = fakeUserId
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

    public async Task<BaseResponseDto<UserProfileDto>> GetUserProfile(Guid userId)
    {
        var dbUser = await _dbContext.Set<User>()
            .Where(u => u.Id == userId)
            .SingleOrDefaultAsync();

        var dbProfile = _mapper.Map<UserProfileDto>(dbUser);

        if (dbUser == null)
        {
            return new BaseResponseDto<UserProfileDto> { Message = "Not found", Success = false };
        }

        dbProfile.JoinedDate = dbUser.CreatedOn;

        return new BaseResponseDto<UserProfileDto> { Message = "User found", Success = true, Data = dbProfile };
    }

    //patch user type [admin only]

    public async Task<BaseResponseDto> UpdateUser(Guid userId, NewUserRequestDto UserRequestDto)
    {
        var dbUser = _dbContext.Set<User>().SingleOrDefault(u => u.Id == userId);

        if (dbUser == null)
        {
            return new BaseResponseDto { Message = $"User with id #{userId} does not exist.", Success = false };
        }

        _mapper.Map(UserRequestDto, dbUser);
        await _dbContext.SaveChangesAsync();

        return new BaseResponseDto { Message = "User information updated.", Success = true };
    }

    public async Task<BaseResponseDto> DeleteUser(Guid userId)
    {
        var dbUser = _dbContext.Set<User>().SingleOrDefault(u => u.Id == userId);

        if (dbUser == null)
        {
            return new BaseResponseDto { Message = $"User with id #{userId} does not exist.", Success = false };
        }

        _dbContext.Remove(dbUser);
        await _dbContext.SaveChangesAsync();

        return new BaseResponseDto { Message = "User has been deleted.", Success = true };
    }

}