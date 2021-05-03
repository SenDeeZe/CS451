using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Services
{
    public interface IPostProvider
    {
        List<PostModel> GetUserPosts(UserModel user);
    }
    public class PostProvider: IPostProvider
    {
        public List<PostModel> GetUserPosts(UserModel user)
        {
            var postWithImage = new Models.PostModel
            {
                Author = user,
                Image = "https://picsum.photos/300/300",
                Text = "i have a new pic!",
                Date = DateTime.Now
            };

            var postWithoutImage = new Models.PostModel
            {
                Author = user,
                Text = "i have no new pics :(",
                Date = DateTime.Now
            };

            return new List<PostModel> { postWithoutImage, postWithImage };
        }
    }
}
