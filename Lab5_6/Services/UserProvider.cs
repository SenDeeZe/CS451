using Lab5_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_6.Services
{
    public interface IUserProvider
    {
        User GetCurrentUser();
    };
    public class UserProvider: IUserProvider
    {
        public User GetCurrentUser()
        {
            return new User
            {
                Name = "Matvei Vasyura",
                UserName = "Matej",
                Bio = "hi!",
                Image = "https://picsum.photos/150/150"
            };
        }
    }
}
