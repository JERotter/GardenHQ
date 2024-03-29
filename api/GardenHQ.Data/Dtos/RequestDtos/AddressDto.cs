﻿using System;
namespace GardenHQ.Data.Dtos.RequestDtos;

public class AddressDto
{
    public string? StreetAddress { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? ZipCode { get; set; }
}