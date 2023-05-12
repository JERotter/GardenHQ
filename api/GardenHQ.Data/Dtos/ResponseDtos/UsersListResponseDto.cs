﻿using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos.ResponseDtos;

public class UsersListResponseDto
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public UserType Type { get; set; }
}