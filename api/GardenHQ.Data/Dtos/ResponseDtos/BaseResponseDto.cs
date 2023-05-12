using System;
namespace GardenHQ.Data.Dtos.ResponseDtos;

public class BaseResponseDto
{
    public string Message { get; set; }
    public bool Success { get; set; }
}


public class BaseResponseDto<T> : BaseResponseDto
{
    public string Message { get; set; }
    public bool Success { get; set; }

    public T Data { get; set; }
}
