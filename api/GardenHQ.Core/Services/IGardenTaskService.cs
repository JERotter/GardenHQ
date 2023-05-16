using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;

namespace GardenHQ.Core.Services;

public interface IGardenTaskService
{
    //Task<BaseResponseDto> PopulateTasks();

    Task<BaseResponseDto> CreateTask(NewTaskRequestDto taskRequestDto);
}