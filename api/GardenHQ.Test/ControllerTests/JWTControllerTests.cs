using System;
using AutoMapper;
using FluentAssertions;
using GardenHQ.Api.Controllers;
using GardenHQ.Core.Services;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using GardenHQ.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace GardenHQ.Test.ControllerTests;

public class JWTControllerTests
{
    private readonly Mock<ILogger<JWTController>> _mockLogger;
    private readonly Mock<IJWTService> _mockIJWTService;
    private readonly JWTController _sut;

    public JWTControllerTests()
	{
        _mockLogger = new Mock<ILogger<JWTController>>();
        _mockIJWTService = new Mock<IJWTService>();
        _sut = new JWTController(_mockIJWTService.Object, _mockLogger.Object);
    }

    [Fact]
    public async Task RegisterNewUser_ReturnsStatusCode200_OnSuccess()
    {
        //Arrange
        var fakeAddressDto = new AddressDto
        {
            StreetAddress = "333 string st",
            StreetAddressLine2 = null,
            City = "stringTowne",
            State = "PA",
            Country = "USA",
            ZipCode = "12345"

        };

        var fakeUserRequestDto = new NewUserRequestDto
        {
            FirstName = "Test M.",
            LastName = "Stringer",
            Email = "Test@testMail.com",
            Address = fakeAddressDto,
            PhoneNumber = "999-999-9999",
            DateOfBirth = "01/01/1990",
            UserName = "Tester01",
            Password = "p@ssWord123",
        };

        var fakeStamp = "0ccb92b4-a725-4140-8a57-7a55c25384aa";

        var expectedResponse = new BaseResponseDto<AuthResult> { Success = true, Message = "New user registered", Data = new AuthResult { Token = fakeStamp } };
        _mockIJWTService.Setup(service => service.RegisterNewUser(fakeUserRequestDto)).ReturnsAsync(expectedResponse);

        //Act
        var testResult = await _sut.RegisterNewUser(fakeUserRequestDto);

        //Assert
        testResult.Should().NotBeNull();
        var obj = testResult.Result as ObjectResult;
        obj.StatusCode.Should().Be(200);
        _mockIJWTService.VerifyAll();
    }

}
