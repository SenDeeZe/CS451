using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class Post
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public User Author { get; set; }
        public string Image { get; set; }
        public int Likes { get; set; }
    }
}
