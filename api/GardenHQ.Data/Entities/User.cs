using System;
namespace GardenHQ.Data.Entities;

public class User
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public UserType Type { get; set; }
}

