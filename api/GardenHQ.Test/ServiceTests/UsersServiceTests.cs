using System;
using AutoMapper;
using GardenHQ.Api.Controllers;
using GardenHQ.Core.Services;
using GardenHQ.Data;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using GardenHQ.Test.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;


namespace GardenHQ.Test.ServiceTests;

public class UsersServiceTests : IClassFixture<BaseTestFixture<UsersServiceTests>>
{
    private readonly UsersService _sut;
    private readonly GardenDbContext _dbContext;
    private readonly IMapper _mapper;

    public UsersServiceTests(BaseTestFixture<UsersServiceTests> baseTestFixture)
    {
        _mapper = baseTestFixture._mapper;

        //InMemory db
        var optionsBuilder = new DbContextOptionsBuilder<GardenDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
        .Options;

        _dbContext = new GardenDbContext(optionsBuilder);
        _dbContext.Database.EnsureCreated();

        _sut = new UsersService(_dbContext, _mapper);

    }


    [Fact]
    public async Task GetUsers_ReturnsSuccessMessage_WhenUsersFound()
    {
        //Arrange
        var fakeUserId = new Guid();

        var fakeAddress = new Address
        {
            Id = new Guid(),
            StreetAddress = "123 four st",
            StreetAddressLine2 = null,
            City = "CityTowneShire",
            Country = "United States",
            ZipCode = "12345",
            State = "HI",
            CreatedBy = new Guid(),
            LastUpdatedBy = new Guid(),
            CreatedOn = DateTime.UtcNow,
            LastUpdated = DateTime.UtcNow

        };

        var fakeUser = new User
        {
            CreatedBy = fakeUserId,
            LastUpdatedBy = fakeUserId,
            LastUpdated = DateTime.UtcNow,
            CreatedOn = DateTime.UtcNow,
            FirstName = "M.",
            LastName = "Stringer",
            Email = "string@string",
            Address = fakeAddress,
            Phone = "(111) 555 - 5555",
            DateOfBirth = "5/9/1998",
            AssignedTasks = null,
            Type = UserType.Volunteer,
            Id = fakeUserId,
            AbbreviatedId = fakeUserId.ToString().Substring(0, 4),

        };

        _dbContext.Add(fakeUser);
        _dbContext.SaveChanges();

        List<UsersListResponseDto> fakeUserList = new List<UsersListResponseDto>();

        var fakeUsersDto = new UsersListResponseDto
        {
            AbbreviatedId = fakeUser.Id.ToString().Substring(0, 4),
            FirstName = fakeUser.FirstName,
            Id = fakeUser.Id,
            LastName = fakeUser.LastName,
            Type = fakeUser.Type.ToString()
        };

        fakeUserList.Add(fakeUsersDto);

        var expectedUsers = new BaseResponseDto<List<UsersListResponseDto>> { Success = true, Data = fakeUserList };

        //Act
        var testVerification = await _sut.GetUsers();

        //Assert
        var testVal = testVerification.Data;
        var testName = testVal.Select(t => t.LastName).First();
        Assert.True(testVerification.Success);
        Assert.Equal("Stringer", testName);
    }

}

