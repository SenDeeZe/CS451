using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Services
{
    public interface IUserProvider
    {
        UserModel GetCurrentUser();
    };
    public class UserProvider: IUserProvider
    {
        public UserModel GetCurrentUser()
        {
            return new UserModel
            {
                Name = "Sergei Tareev",
                UserName = "Tareev",
                Bio = "wassup!",
                Image = "https://picsum.photos/150/150"
            };
        }
    }
}
