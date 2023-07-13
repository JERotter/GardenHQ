using System;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Dtos;

public class LoginRequestDto
{ 
    public string Email { get; set; }
    public string Password { get; set; }
}
