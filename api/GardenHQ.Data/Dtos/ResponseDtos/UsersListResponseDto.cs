using System;
using System.Text.Json.Serialization;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class UsersListResponseDto
{
	public Guid Id { get; set; }
    public string AbbreviatedId { get; set; }
    public string FirstName { get; set; }
	public string LastName { get; set; }
    //public string Type { get; set; }// join?
}