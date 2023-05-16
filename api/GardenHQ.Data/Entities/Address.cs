using System;
using System.ComponentModel.DataAnnotations;

namespace GardenHQ.Data.Entities;

public class Address : BaseEntity
{
    public string? StreetAddress { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
    private DateTime? createdOn;

    [DataType(DataType.DateTime)]
    public DateTime? CreatedOn
    {
        get { return createdOn ?? DateTime.UtcNow; }
        set { createdOn = value; }
    }

    /// <summary>
    /// This method records the time stamp and user information when creating a comment
    /// </summary>
    /// <param name="author"></param>
    public void Create()
    {
        this.CreatedOn = DateTime.UtcNow;
    }
}