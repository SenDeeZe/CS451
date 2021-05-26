using Lab5_6.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5_6.Models
{
    public class DbInitializer
    {
        public static void Initialize(IdentityContext context)
        {
            // Look for any students.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                new User{ Name = "Matvei", UserName = "Matej", Bio = "I always do all the job", Image = "https://thispersondoesnotexist.com/image" },
                new User{ Name = "Kate", UserName = "piupiupiu", Bio = "I'm literally the greatest", Image = "https://thispersondoesnotexist.com/image" },
                new User{ Name = "Sasha", UserName = "STICH", Bio = "I can touch the skies", Image = "https://thispersondoesnotexist.com/image" },
                new User{ Name = "Artemon", UserName = "Zapr", Bio = "Check out my new wheels!", Image = "https://thispersondoesnotexist.com/image" }
            };

            users[0].Subscribers = new List<User> { users[1], users[2] };
            users[0].Subscriptions = new List<User> { users[1] };
            users[1].Subscriptions = new List<User> { users[2] };

            var posts = new Post[]
            {
                new Post
                { Date = DateTime.Now,
                    Text = "Lorem ipsum dolor sit amet", Likes = 14, Author = users[0], Image = "https://picsum.photos/300/300"
                },
                new Post
                {  Date = DateTime.Now,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    Likes = 14, Author = users[0], Image = ""
                }
            };

            users[0].Posts = posts.ToList();

            context.Users.AddRange(users);
            context.SaveChanges();

            context.Posts.AddRange(posts);
            context.SaveChanges();
            
        }
    }
}
