using System.Threading.Tasks;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;

namespace GardenHQ.Core.Services;

public interface IGardenTaskService
{
    //Task<BaseResponseDto> PopulateTasks();
    Task<BaseResponseDto> CreateTask(NewTaskRequestDto taskRequestDto);
    Task<BaseResponseDto<IEnumerable<TaskTableDto>>> GetTasks();
    Task<BaseResponseDto<TaskDetailDto>> GetTaskDetail(Guid taskId);
    Task<BaseResponseDto> UpdateTask(Guid taskId, NewTaskRequestDto taskRequestDto);
    Task<BaseResponseDto> DeleteTask(Guid taskId);
}