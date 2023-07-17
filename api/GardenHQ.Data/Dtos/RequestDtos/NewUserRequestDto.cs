using System;
using System.Text.Json.Serialization;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.RequestDtos;

public class NewUserRequestDto
{
    //public string invitationCode {get; set; }
    [JsonIgnore]
    public string AbbreviatedId { get; set; } = "0000";
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public AddressDto? Address { get; set; }
    public string PhoneNumber { get; set; }
    public string DateOfBirth { get; set; }
    public string UserName { get; set; }
	public string Password { get; set; }
}