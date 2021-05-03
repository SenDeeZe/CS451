using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4.Models.ViewModels;
using Lab4.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class FeedController : Controller
    {
        private readonly IUserProvider _user;
        private readonly IPostProvider _posts;

        public FeedController(IUserProvider user, IPostProvider posts)
        {
            _user = user;
            _posts = posts;
        }
        public IActionResult Index()
        {
            var model = new IndexViewModel(_user, _posts);
            return View(model);
        }
    }
}
