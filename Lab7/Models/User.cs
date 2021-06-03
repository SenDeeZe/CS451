using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class User: IdentityUser
    {
        public string Name { get; set; }
        public List<User> Subscriptions { get; set; }
        public List<User> Subscribers { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
        public List<Post> Posts { get; set; }
        public string Role { get; set; }
        
        public User()
        {
            Subscribers = new List<User>();
            Subscriptions = new List<User>();
            Posts = new List<Post>();
        }
    }
}
