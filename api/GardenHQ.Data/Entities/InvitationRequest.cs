using System;
namespace GardenHQ.Data.Entities;

public class InvitationRequest : BaseEntity
{
    //contact form
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
}