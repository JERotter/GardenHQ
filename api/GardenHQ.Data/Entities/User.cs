using System;
namespace GardenHQ.Data.Entities;

public class User : BaseEntity
{
	public int AbbreviatedId { get; set; }
    public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public Address Address { get; set; }
	public string Phone { get; set; }
    public string DateOfBirth { get; set; }
    public UserType Type { get; set; }
	public List<GardenTask>? AssignedTasks { get; set; }
}