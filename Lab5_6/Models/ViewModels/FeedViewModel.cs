using Lab5_6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_6.Models.ViewModels
{
    public class FeedViewModel
    {
        public User User { get; set; }
        public List<Post> Posts { get; set; }
    }
}
