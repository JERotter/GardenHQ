using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenHQ.Common.Authentication;
using GardenHQ.Core.Services;
using GardenHQ.Data.Dtos;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
//Auth:
//https://www.youtube.com/watch?v=mgeuh8k3I4g&ab_channel=NickChapsas
//https://www.youtube.com/watch?v=Y-MjCw6thao&list=TLPQMTEwNzIwMjNiW3NlgnSO1Q&index=2&ab_channel=MohamadLawand

namespace GardenHQ.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JWTController : ControllerBase
{
    private readonly IJWTService _jWTService;
    private readonly ILogger<JWTController> _logger;


    public JWTController(IJWTService jWTService, ILogger<JWTController> logger )
    {
        _jWTService = jWTService;
        _logger = logger;

    }

    [HttpPost("Registration")]
    public async Task<ActionResult<BaseResponseDto<AuthResult>>> RegisterNewUser( NewUserRequestDto dto)
    {
        var resp = await _jWTService.RegisterNewUser(dto);

        return resp.Success ? Ok(resp.Data) : BadRequest();
    }

    [HttpPost("Login")]
    public async Task<ActionResult<BaseResponseDto<string>>> Login(LoginRequestDto login)
    {
        var resp = await _jWTService.Login(login);

        return resp.Success ? Ok(resp.Data) : BadRequest();
    }
}

