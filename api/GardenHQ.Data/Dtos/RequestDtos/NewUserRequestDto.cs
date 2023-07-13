using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.RequestDtos;

public class NewUserRequestDto
{
    //public string invitationCode {get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Address? Address { get; set; }
    public string PhoneNumber { get; set; }
    public string DateOfBirth { get; set; }
	public string Password { get; set; }
	public UserStatus Status { get; set; } = UserStatus.Member;
}