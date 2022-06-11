using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Authentication;
using SimpleAPI.Data.Interfaces;
using SimpleAPI.Dtos;
using SimpleAPI.Models;
using System.Security.Claims;

namespace SimpleAPI.Controllers
{
    
    [ApiController]
    [Authorize]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        private readonly IConfiguration _config;

        public UserController(IUserRepo repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
        }

        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Login([FromBody] UserLogin userLogin)
        {
            if (userLogin == null) return BadRequest("User login missing");

            User user = _repo.UserLogin(userLogin);
            if (user == null) return NotFound("User Not Found");

            var token = new AuthenticationManager().getToken(user, _config);
            
            user.Password = String.Empty;
            LoginResponse response = new()
            {
                User = user,
                Token = token
            };
            return Ok(response);
        }


        [HttpGet("GetByUsername/{username}")]
        public IActionResult GetByUsername(string username)
        {
            User user = _repo.GetUserByName(username);
            if (user is not null)
            {
                return Ok(user);
            }
            return NotFound("User does not exist");            
        }

        [HttpGet("Public")]
        [Authorize(Roles = "Teacher")]

        public IActionResult Public()
        {
            return Ok("OK OK OK");
        }

        [HttpGet("Admin")]
        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            User user = GetCurrentUser();
            return Ok("OK OK OK Admin" + user.Email);
        }

        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity is not null)
            {
                var userClaims = identity.Claims;
                return new User()
                {
                    UserName = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value,
                    Email = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value,
                    FirstName = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.GivenName)?.Value,
                    ParentName = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Surname)?.Value,
                    Role = userClaims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }

    }
}
