using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.RequestDtos;

public class NewUserRequestDto
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public UserType Type { get; set; } = UserType.Volunteer;
}