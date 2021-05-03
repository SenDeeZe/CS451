using Lab4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models.ViewModels
{
    public class IndexViewModel
    {
        public UserModel User { get; set; }
        public List<PostModel> Posts { get; set; }
        public IndexViewModel(IUserProvider user, IPostProvider posts)
        {
            User = user.GetCurrentUser();
            Posts = posts.GetUserPosts(User);
        }
    }
}
