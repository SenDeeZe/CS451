using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Services
{
    public interface IPostProvider
    {
        List<Post> GetUserPosts(User user);
    }
    public class PostProvider: IPostProvider
    {
        public List<Post> GetUserPosts(User user)
        {
            var postWithImage = new Post
            {
                Author = user,
                Image = "https://picsum.photos/300/300",
                Text = "i have a new pic!",
                Date = DateTime.Now
            };

            var postWithoutImage = new Post
            {
                Author = user,
                Text = "i have no new pics :(",
                Date = DateTime.Now
            };

            return new List<Post> { postWithoutImage, postWithImage };
        }
    }
}
