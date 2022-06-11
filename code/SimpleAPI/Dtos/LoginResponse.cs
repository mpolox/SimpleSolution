using SimpleAPI.Models;

namespace SimpleAPI.Dtos
{
    public class LoginResponse
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
