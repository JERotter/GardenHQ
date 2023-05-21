using System;
namespace GardenHQ.Data.Dtos.RequestDtos;

public class DonationRequestDto
{
    //contact form #2
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public int Amount { get; set; }
}