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
        //https://docs.automapper.org/en/stable/Custom-type-converters.html
        CreateMap<UserStatus, string>().ConvertUsing(x => x.ToString());
        CreateMap<string, DateOnly>().ConvertUsing(x => DateOnly.Parse(x));
        CreateMap<string, TimeOnly>().ConvertUsing(x => TimeOnly.Parse(x));
        CreateMap<DateOnly, string>().ConvertUsing(x => x.ToString("MM/dd/yyyy"));
        CreateMap<DateTime, string>().ConvertUsing(x => x.ToString("MM/dd/yyyy"));

        // CreateMap<List<Teams>, string>().ConvertUsing(x => (
        //    x.Contains(UserTypes.Admin) ? "Admin" :
        //    x.Contains(UserTypes.Manager) ? "Manager" :
        //    x.Contains(UserTypes.Volunteer) ? "Volunteer" :
        //    "Status not accounted for. Mapping profile needs to be updated."
        //));

        //source, destination
        //users
        CreateMap<User, UsersListResponseDto>();
        CreateMap<NewUserRequestDto, User>();
        CreateMap<User, UserProfileDto>();

        //tasks
        CreateMap<GardenTask, TaskTableDto>();
        CreateMap<NewTaskRequestDto, GardenTask>();
        CreateMap<GardenTask, TaskDetailDto>();
    }
}

