using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class TaskDetailDto : BaseResponseDto
{
    public DateTime CreatedOn { get; set; }
    public string Title { get; set; }
    public Priority priority { get; set; }
    public Guid AssignedTo { get; set; }
    public string? AssignedName { get; set; }
    public bool Completed { get; set; }
    public string CompletedDate { get; set; }
}
