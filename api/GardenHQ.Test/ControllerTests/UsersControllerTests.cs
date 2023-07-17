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

namespace GardenHQ.ControllerTests.UsersControllerTests;


public class UsersControllerTests
{
    private readonly Mock<ILogger<UsersController>> _mockLogger;
    private readonly Mock<IUsersService> _mockUsersService;
    private readonly UsersController _sut;

    public UsersControllerTests()
    {
        _mockLogger = new Mock<ILogger<UsersController>>();
        _mockUsersService = new Mock<IUsersService>();
        _sut = new UsersController(_mockUsersService.Object, _mockLogger.Object);

    }

    #region Failure States

    #endregion

    #region Passing States
[Fact]
public async Task GetUsers_ReturnsStatusCode200_OnSuccess()
{
    //Arrange
    var fakeUserResponseDto = new UsersListResponseDto
    {
        FirstName = "Test M.",
        LastName = "Stringer",
    };
    var fakeUserList = new List<UsersListResponseDto>();
    fakeUserList.Add(fakeUserResponseDto);


    var expectedResponse = new BaseResponseDto<IEnumerable<UsersListResponseDto>> { Message = "Users found", Success = true, Data = fakeUserList };
    _mockUsersService.Setup(service => service.GetUsers()).ReturnsAsync(expectedResponse);

    //Act
    var testResult = await _sut.GetUsers();

    //Assert
    testResult.Should().NotBeNull();
    var obj = testResult.Result as ObjectResult;
    obj.StatusCode.Should().Be(200);
    _mockUsersService.VerifyAll();
}
}

//Task<BaseResponseDto> CreateUser(NewUserRequestDto requestDto);
//Task<BaseResponseDto<IEnumerable<UsersListResponseDto>>> GetUsers();
//[Fact]
//public async Task UpdateEmployee_ReturnsStatusCode200_OnSuccess()
//{
//    //Arrange
//    //var fakeCreateDto = _serviceMocks.GetfakeEmployeeResponseDto();

//    var fakeUserId = new Guid();

//    var fakeEmployeeRequestDto = new EmployeeRequestDto
//    {
//        FirstName = "Test M.",
//        LastName = "Stringer",
//        Email = "string@string",
//    };

//    var fakeEmployeeResponseDto = new EmployeeResponseDto
//    {
//        FirstName = "Test M.",
//        LastName = "Stringer",
//    };

//    var expectedResponse = new BaseResponseDto { Message = $"The employee record for {fakeEmployeeResponseDto.FirstName} has been deleted.", Success = true };
//    _mockEmployeeService.Setup(service => service.UpdateEmployee(fakeUserId, fakeEmployeeRequestDto)).ReturnsAsync(expectedResponse);

//    //Act
//    var testResult = await _sut.UpdateEmployee(fakeUserId, fakeEmployeeRequestDto);

//    //Assert
//    testResult.Should().NotBeNull();
//    var obj = testResult.Result as ObjectResult;
//    //var objMessage = testResult
//    obj.StatusCode.Should().Be(200);
//    _mockEmployeeService.VerifyAll();
//}
#endregion