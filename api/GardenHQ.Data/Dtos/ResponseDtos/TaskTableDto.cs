using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class TaskTableDto : BaseResponseDto
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public DateTime CreatedOn { get; set; }
	public Priority Priority { get; set; }
	public bool Completed { get; set; }
}