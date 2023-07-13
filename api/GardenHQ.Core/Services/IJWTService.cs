using System.IdentityModel.Tokens.Jwt;
using GardenHQ.Data.Dtos;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GardenHQ.Core.Services
{
    public interface IJWTService
    {
        Task<BaseResponseDto<string>> Login([FromBody] LoginRequestDto login);
        Task<BaseResponseDto<AuthResult>> RefreshToken([FromBody] NewUserRequestDto dto);
        Task<BaseResponseDto<AuthResult>> RegisterNewUser([FromBody] NewUserRequestDto dto);
        Task<BaseResponseDto<AuthResult>> RevokeToken([FromBody] NewUserRequestDto dto);
    }
}