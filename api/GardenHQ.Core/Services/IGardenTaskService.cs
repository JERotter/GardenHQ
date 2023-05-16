using GardenHQ.Data.Dtos.ResponseDtos;

namespace GardenHQ.Core.Services;

public interface IGardenTaskService
{
    Task<BaseResponseDto> PopulateTasks();
}