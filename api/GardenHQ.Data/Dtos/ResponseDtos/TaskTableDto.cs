using System;
using System.Text.Json.Serialization;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class TaskTableDto
{
	public Guid Id { get; set; }
    public string AbbreviatedId { get; set; }
    public string Title { get; set; }
    public string CreatedOn { get; set; }
    public string Priority { get; set; }
	public bool Completed { get; set; }
}