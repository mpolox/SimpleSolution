using SimpleAPI.Models;

namespace SimpleAPI.Data.Interfaces
{
    public class UserRepo
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                UserName = "polo",
                Email = "mpolox@gmail.com",
                Password = "polo",
                FirstName = "Marcopolo",
                ParentName = "Ramos",
                Role = "Admin"
            },
            new User()
            {
                UserName = "ale",
                Email = "ale@gmail.com",
                Password = "ale",
                FirstName = "Alexandra",
                ParentName = "Galvan",
                Role = "Teacher"
            },
            new User()
            {
                UserName = "emy",
                Email = "emy@gmail.com",
                Password = "emy",
                FirstName = "Emilia",
                ParentName = "Ramos",
                Role = "Student"
            },
            new User()
            {
                UserName = "polin",
                Email = "polin@gmail.com",
                Password = "polin",
                FirstName = "Marcopolo",
                ParentName = "Ramos Galvan",
                Role = "Student"
            }
        };
        
    }
}
