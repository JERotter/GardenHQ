using System;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;

namespace GardenHQ.Core.Services;

public interface IUsersService
{
    Task<BaseResponseDto> PopulateUsers();
    //Task<BaseResponseDto> CreateUser(NewUserRequestDto requestDto);
    Task<BaseResponseDto<IEnumerable<UsersListResponseDto>>> GetUsers();
    Task<BaseResponseDto<UserProfileDto>> GetUserProfile(Guid userId);
    Task<BaseResponseDto> UpdateUser(Guid UserId, NewUserRequestDto UserRequestDto);
    Task<BaseResponseDto> DeleteUser(Guid UserId);
}