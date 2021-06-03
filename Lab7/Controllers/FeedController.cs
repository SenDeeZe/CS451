using Lab7.Models;
using Lab7.Models.ViewModels;
using Lab7.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Lab7.Controllers
{
    public class FeedController: Controller
    {
        private IdentityContext _context;

        public FeedController( IdentityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult Index(string ID)
        {
            User currentUser = _context.Users.FirstOrDefault(user => user.Id == ID.ToString());
            if (currentUser == null)
            {
                return NotFound();
            }

            List<Post> posts = _context.Posts.Where(post => post.Author.Id == currentUser.Id).ToList();

            var model = new FeedViewModel
            {
                User = currentUser,
                Posts = posts
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create([FromForm] PostEdit postModel)
        {
            User user = _context.Users.FirstOrDefault(user => user.Id == postModel.UserId.ToString());
            if (user == null)
            {
                return NotFound("User not found");
            }

            if (User.Identity.Name != user.UserName)
            {
                return BadRequest("Not Authorized");
            }

            Post post = new Post
            {
                Text = postModel.Text,
                Date = DateTime.Now,
                Image = postModel.Image,
                Likes = 0,
                Author = user
            };

            user.Posts.Add(post);
            _context.Posts.Add(post);
            _context.SaveChanges();

            return RedirectToAction("Index", "Feed", new { id = postModel.UserId });
        }

        [HttpGet]
        public IActionResult Edit(long? id, string? userId)
        {
            Post post = _context.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null)
            {
                return NotFound("Post not found");
            }

            User user = _context.Users.FirstOrDefault(user => user.Id == userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            if (User.Identity.Name != user.UserName)
            {
                return BadRequest("Not Authorized");
            }

            PostEdit model = new PostEdit
            {
                UserId = user.Id,
                Text = post.Text,
                Image = post.Image
            };

            _context.Posts.Remove(post);
            _context.SaveChanges();

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int? id, string? userId)
        {
            Post post = _context.Posts.Where(x => x.Id == id).FirstOrDefault();
            if (post == null)
            {
                return NotFound("Post not found");
            }

            User user = _context.Users.FirstOrDefault(user => user.Id == userId);
            if (user == null)
            {
                return NotFound("User not found");
            }

            if (User.Identity.Name != user.UserName)
            {
                return BadRequest("Not Authorized");
            }

            _context.Posts.Remove(post);
            _context.SaveChanges();

            return RedirectToAction("Index", "Feed", new { id = userId });
        }
    }
}
