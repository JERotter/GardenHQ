using System;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;

namespace GardenHQ.Core.Services;

public interface IUsersService
{
    Task<BaseResponseDto> PopulateUsers();
    Task<BaseResponseDto> CreateUser(NewUserRequestDto requestDto);
    Task<BaseResponseDto<IEnumerable<UsersListResponseDto>>> GetUsers();
}