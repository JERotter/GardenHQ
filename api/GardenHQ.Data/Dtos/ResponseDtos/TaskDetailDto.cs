using System;
using System.Text.Json.Serialization;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class TaskDetailDto
{
    public Guid Id { get; set; }
    public string AbbreviatedId { get; set; }
    [JsonPropertyName("StartDate")]
    public string CreatedOn { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string priority { get; set; }
    public Guid? AssignedTo { get; set; }
    public string? AssignedName { get; set; }
    public bool Completed { get; set; }
    public string CompletedDate { get; set; }
}
