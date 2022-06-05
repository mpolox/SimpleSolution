using SimpleAPI.Models;

namespace SimpleAPI.Data.Interfaces
{
    public class UserRepo
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                UserName = "mpolox",
                Email = "mpolox@gmail.com",
                Password = "12345",
                FirstName = "Marcopolo",
                ParentName = "Ramos",
                Role = "Admin"
            },
            new User()
            {
                UserName = "alex",
                Email = "alex@gmail.com",
                Password = "12345",
                FirstName = "Alexandra",
                ParentName = "Galvan",
                Role = "Teacher"
            },
            new User()
            {
                UserName = "emy",
                Email = "emy@gmail.com",
                Password = "12345",
                FirstName = "Emilia",
                ParentName = "Ramos",
                Role = "Student"
            },
            new User()
            {
                UserName = "string",
                Email = "mpolox@gmail.com",
                Password = "string",
                FirstName = "MarcopoloStr",
                ParentName = "Ramos",
                Role = "Admin"
            }
        };
        
    }
}
