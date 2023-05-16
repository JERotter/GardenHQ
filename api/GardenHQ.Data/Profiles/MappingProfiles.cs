using System;
using AutoMapper;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;

namespace GardenHQ.Data.Profiles;

public class MappingProfiles : Profile
{
	public MappingProfiles()
	{
        CreateMap<DateTime, string>().ConvertUsing(x => x.ToString("MM/dd/yyyy"));

        // CreateMap<List<UserRoles>, string>().ConvertUsing(x => (
        //    x.Contains(UserRoles.Admin) ? "Admin" :
        //    x.Contains(UserRoles.Manager) ? "Manager" :
        //    x.Contains(UserRoles.Volunteer) ? "Volunteer" :
        //    "Status not accounted for. Mapping profile needs to be updated."
        //));

        //source, destination
        //users
        CreateMap<User, UsersListResponseDto>();
        CreateMap<NewUserRequestDto, User>();
        CreateMap<User, UserProfileDto>();

        //tasks
        CreateMap<Task, TaskTableDto>();
        CreateMap<NewTaskRequestDto, Task>();
    }
}

