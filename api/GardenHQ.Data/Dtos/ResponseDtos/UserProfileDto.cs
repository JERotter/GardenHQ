using System;
using System.Text.Json.Serialization;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class UserProfileDto
{
    public string AbbreviatedId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public string DateOfBirth { get; set; }
    [JsonPropertyName("StartDate")]
    public string CreatedOn { get; set; }
    public string Type { get; set; }
    public List<GardenTask>? AssignedTasks { get; set; }
}