using System;
using GardenHQ.Core.Services;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Mvc;

namespace GardenHQ.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GardenTaskController : ControllerBase
{
    private readonly IUsersService _taskService;
    private readonly ILogger<UsersController> _logger;

    public GardenTaskController(IUsersService taskService, ILogger<UsersController> logger)
    {
        _taskService = taskService;
        _logger = logger;
    }

    //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost("Populate")]
    public async Task<ActionResult<BaseResponseDto>> PostTasks()
    {
        var response = await _taskService.PopulateUsers();

        return response.Success ? Ok(response) : NotFound(response);
    }

//    [HttpPost]
//    public async Task<ActionResult<BaseResponseDto>> CreateUser(NewUserRequestDto requestDto)
//    {
//        var response = await _taskService.CreateUser(requestDto);

//        return response.Success ? Ok(response) : NotFound(response);

//    }

//    [HttpGet("Users")]
//    public async Task<ActionResult<IEnumerable<UsersListResponseDto>>> GetUsers()
//    {
//        var response = await _taskService.GetUsers();

//        return response.Success ? Ok(response) : NotFound(response);
//    }

//    [HttpPut]
//    public async Task<ActionResult<BaseResponseDto>> PutUsers(Guid userId, NewUserRequestDto UserRequestDto)
//    {
//        var response = await _taskService.UpdateUser(userId, UserRequestDto);

//        return response.Success ? Ok(response) : NotFound(response);
//    }

//    [HttpDelete]
//    public async Task<ActionResult<BaseResponseDto>> DeleteUser(Guid userId)
//    {
//        var response = await _taskService.DeleteUser(userId);

//        return response.Success ? Ok(response) : NotFound(response);
//    }
//
}
