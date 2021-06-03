using Lab7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models.ViewModels
{
    public class FeedViewModel
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}
