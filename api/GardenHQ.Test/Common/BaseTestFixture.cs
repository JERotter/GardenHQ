using System;
using AutoMapper;
using GardenHQ.Data.Profiles;

namespace GardenHQ.Test.Common;

public class BaseTestFixture<T> : IDisposable
{
    public readonly IMapper _mapper;

    public BaseTestFixture()
    {
        //Mapper
        var configurationProvider = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<MappingProfiles>();
        });

        _mapper = configurationProvider.CreateMapper();
    }

    public void Dispose()
    {

    }
}
