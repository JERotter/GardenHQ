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
       // CreateMap<List<EmployeeRoles>, string>().ConvertUsing(x => (
       //    x.Contains(EmployeeRoles.Admin) ? "Admin" :
       //    x.Contains(EmployeeRoles.Minion) ? "Minion" :
       //    x.Contains(EmployeeRoles.Peon) ? "Peon" :

       //    "Status not accounted for. Mapping profile needs to be updated."
       //));

        //source, destination
        CreateMap<User, UsersListResponseDto>();
        //CreateMap<EmployeeResponseDto, User>();
        CreateMap<NewUserRequestDto, User>();
        //CreateMap<DepartmentRequestDto, Department>();
        //CreateMap<Department, DepartmentResponseDto>();

    }
}

