using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Services
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
