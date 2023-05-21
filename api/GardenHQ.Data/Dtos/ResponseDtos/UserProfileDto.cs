using System;
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
    public DateTime? JoinedDate { get; set; }
    public UserType Type { get; set; }
    public List<GardenTask>? AssignedTasks { get; set; }
}