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
    public Guid UserId { get; set; }
}