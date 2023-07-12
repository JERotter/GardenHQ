using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GardenHQ.Data.Entities;


public class User : IdentityUser<Guid>
{
    public string AbbreviatedId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Address? Address { get; set; }
    public string PhoneNumber { get; set; }
    public string DateOfBirth { get; set; }
    public UserStatus Status { get; set; }
    public List<GardenTask>? AssignedTasks { get; set; }

    public Guid CreatedBy { get; set; }

    private DateTime? createdOn;

    [DataType(DataType.DateTime)]
    public DateTime? CreatedOn
    {
        get { return createdOn ?? DateTime.UtcNow; }
        set { createdOn = value; }
    }

    private DateTime? lastUpdated;

    public Guid LastUpdatedBy { get; set; }

    [DataType(DataType.DateTime)]
    public DateTime? LastUpdated
    {
        get { return lastUpdated ?? DateTime.UtcNow; }
        set { lastUpdated = value; }
    }

    public void Create(Guid author)
    {
        this.CreatedBy = author;
        this.CreatedOn = DateTime.UtcNow;
        this.LastUpdatedBy = author;
        this.LastUpdated = DateTime.UtcNow;
    }

}

//public class User : BaseEntity
//{
//	public string AbbreviatedId { get; set; }
//    public string FirstName { get; set; }
//	public string LastName { get; set; }
//	public string Email { get; set; }
//	public Address Address { get; set; }
//	public string Phone { get; set; }
//    public string DateOfBirth { get; set; }
//    public UserType Type { get; set; }
//	public List<GardenTask>? AssignedTasks { get; set; }
//}