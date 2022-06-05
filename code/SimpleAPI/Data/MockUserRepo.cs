using Microsoft.IdentityModel.Tokens;
using SimpleAPI.Data.Interfaces;
using SimpleAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SimpleAPI.Data
{
    public class MockUserRepo : IUserRepo
    {
        public User UserLogin(UserLogin userLogin)
        {
            User user = UserRepo.Users.FirstOrDefault(u => u.UserName.Equals(userLogin.UserName) && u.Password.Equals(userLogin.Password));
            return user;
        }

        public User GetUserByName(string username)
        {
            User user = UserRepo.Users.FirstOrDefault(u => u.UserName.Equals(username));
            return user;
        }
    }
}
