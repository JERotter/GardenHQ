using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using GardenHQ.Common.Authentication;
using GardenHQ.Data;
using GardenHQ.Data.Dtos;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace GardenHQ.Core.Services;

public class JWTService : IJWTService
{
    private GardenDbContext _dbContext;
    private readonly UserManager<User> _userManager;
    private readonly JwtConfig _jwtConfig;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<JWTService> _logger;

    public JWTService(GardenDbContext dbContext, UserManager<User> userManager, IOptions<JwtConfig> jwtConfig, IMapper mapper, IHttpContextAccessor httpContextAccessor, ILogger<JWTService> logger )
    //public JWTService(GardenDbContext dbContext, UserManager<User> userManager, JwtConfig jwtConfig, IMapper mapper, HttpContextAccessor httpContextAccessor, ILogger<JWTService> logger )
    {
        _dbContext = dbContext;
        _userManager = userManager;
        _jwtConfig = jwtConfig.Value;
        _mapper = mapper;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<BaseResponseDto<AuthResult>> RegisterNewUser([FromBody] NewUserRequestDto dto)
    {
        //if user already exists

        //if invitation codes + email do NOT match invitee info

        //create user object
        var newUser = _mapper.Map<User>(dto);

        //add user to db???
        var createdUser = await _userManager.CreateAsync(newUser, dto.Password);

        //if (!createdUser.Succeeded)
        //{
        //false
        //}

        //update stored user data
        //User.create(newUser.Id)
        //_dbContext.SaveChanges();

        //generate tokens

        //return creation confirmation and token in AuthResult
        return new BaseResponseDto<AuthResult> { };

    }

    //https://www.youtube.com/watch?v=4cFhYUK8wnc&ab_channel=MilanJovanovi%C4%87
    private JwtSecurityToken GenerateToken ( User user)
    {
        var claims = new Claim[] {
            new(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new(JwtRegisteredClaimNames.Email, user.Email)
        };

        var signingCredentials = new SigningCredentials(
             new SymmetricSecurityKey(
                 Encoding.UTF8.GetBytes(_jwtConfig.Secret)),
             SecurityAlgorithms.HmacSha256 );

        var generatedToken = new JwtSecurityToken(
            _jwtConfig.Issuer,
            _jwtConfig.Audience,
            claims,
            null,
            DateTime.UtcNow.AddHours(1),
            signingCredentials );

        return generatedToken;

    }

    public async Task<BaseResponseDto<string>> Login([FromBody] LoginRequestDto login)
    {
        //get user by email from usermanager
        var dbUser = await _userManager.FindByEmailAsync(login.Email);

        //make sure user exists
        if (dbUser == null)
        {
            return new BaseResponseDto<string> { Success = false};
        }

        //make sure pw matches maybe

        //generate jwt
        var generatedToken = GenerateToken(dbUser);

        var userToken = new JwtSecurityTokenHandler().WriteToken(generatedToken);

        //return jwt
        return new BaseResponseDto<string> { Success = true, Message = "Token created", Data = userToken };
          
    }

    public async Task<BaseResponseDto<AuthResult>> RefreshToken([FromBody] NewUserRequestDto dto)
    {
        //no idea
        //return jwt
        return new BaseResponseDto<AuthResult> { };

    }

    public async Task<BaseResponseDto<AuthResult>> RevokeToken([FromBody] NewUserRequestDto dto)
    {
        //return jwt
        return new BaseResponseDto<AuthResult> { };

    }
}

