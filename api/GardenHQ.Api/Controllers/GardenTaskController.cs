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
    private readonly IGardenTaskService _taskService;
    private readonly ILogger<GardenTaskController> _logger;

    public GardenTaskController(IGardenTaskService taskService, ILogger<GardenTaskController> logger)
    {
        _taskService = taskService;
        _logger = logger;
    }

    ////// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    //[HttpPost("Populate")]
    //public async Task<ActionResult<BaseResponseDto>> PopulateTasks()
    //{
    //    var response = await _taskService.PopulateTasks();

    //    return response.Success ? Ok(response) : NotFound(response);
    //}

    [HttpPost]
    public async Task<ActionResult<BaseResponseDto>> CreateTask(NewTaskRequestDto taskRequestDto)
    {
        var response = await _taskService.CreateTask(taskRequestDto);

        return response.Success ? Ok(response) : NotFound(response);

    }

    [HttpGet("tasks")]
    public async Task<ActionResult<IEnumerable<TaskTableDto>>> GetTasks()
    {
        var response = await _taskService.GetTasks();

        return response.Success ? Ok(response) : NotFound(response);
    }

    [HttpGet("taskId")]
    public async Task<ActionResult<BaseResponseDto>> GetTaskDetail(Guid taskId)
    {
        var response = await _taskService.GetTaskDetail(taskId);

        return response.Success ? Ok(response) : NotFound(response);
    }

    [HttpPut("taskId")]
    public async Task<ActionResult<BaseResponseDto>> UpdateTask(Guid taskId, NewTaskRequestDto taskRequestDto)
    {
        var response = await _taskService.UpdateTask(taskId, taskRequestDto);

        return response.Success ? Ok(response) : NotFound(response);
    }
   
    [HttpDelete("taskId")]
    public async Task<ActionResult<BaseResponseDto>> DeleteTask(Guid taskId)
    {
        var response = await _taskService.DeleteTask(taskId);

        return response.Success ? Ok(response) : NotFound(response);
    }

}
