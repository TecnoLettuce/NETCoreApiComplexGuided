using APIComplexEntityFramework.ModelDTO;
using APIComplexEntityFramework.ModelDTO.Eraser;
using APIComplexEntityFramework.ModelDTO.Writter;
using APIComplexEntityFramework.Models;
using APIComplexEntityFramework.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIComplexEntityFramework.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userService.GetAllUsersAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsersById(int id)
        {
            return Ok(await _userService.GetUserByIdAsync(id));
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser(UserWritterDTO user)
        {
            return Ok(await _userService.CreateUserAsync(user));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(UserEraserDTO user)
        {
            return Ok(await _userService.DeleteUserAsync(user));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UserWritterDTO user)
        {
            return Ok(await _userService.UpdateUserAsync(user)) ;
        }




    }
}
