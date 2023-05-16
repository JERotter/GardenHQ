using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.RequestDtos;

public class NewTaskRequestDto
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public Priority priority { get; set; }
}