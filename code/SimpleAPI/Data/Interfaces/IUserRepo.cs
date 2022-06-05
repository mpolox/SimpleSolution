using SimpleAPI.Models;

namespace SimpleAPI.Data.Interfaces
{
    public interface IUserRepo
    {
        public User UserLogin(UserLogin userLogin);
        public User GetUserByName(string userName);

    }
}
