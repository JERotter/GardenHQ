using System;
namespace GardenHQ.Data.Dtos.RequestDtos;

public class InvitationRequestDto
{
    //contact form #1
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}

