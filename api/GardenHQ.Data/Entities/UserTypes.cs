using System;
namespace GardenHQ.Data.Entities;

using Microsoft.AspNetCore.Identity;

public class UserTypes: IdentityRole<Guid>
{

}

//public enum UserType
//{
//    Admin,
//    Manager,
//    Volunteer
//}