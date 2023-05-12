using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GardenHQ.Core.Services;
using GardenHQ.Data.Dtos.RequestDtos;
using GardenHQ.Data.Dtos.ResponseDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GardenHQ.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        private readonly ILogger<UsersController> _logger;

        public UsersController(IUsersService usersService, ILogger<UsersController> logger)
        {
            _usersService = usersService;
            _logger = logger;
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("Populate")]
        public async Task<ActionResult<BaseResponseDto>> PostUsers()
        {
            var response = await _usersService.PopulateUsers();

            return response.Success ? Ok(response) : NotFound(response);
        }

        [HttpPost]
        public async Task<ActionResult<BaseResponseDto>> CreateUser(NewUserRequestDto requestDto)
        {
            var response = await _usersService.CreateUser(requestDto);

            return response.Success ? Ok(response) : NotFound(response);

        }

        // GET: api/Employee
        [HttpGet("Users")]
        public async Task<ActionResult<IEnumerable<UsersListResponseDto>>> GetUsers()
        {
            var response = await _usersService.GetUsers();

            return response.Success ? Ok(response) : NotFound(response);
        }

        //// GET: api/Users/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Users
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Users/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/Users/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
