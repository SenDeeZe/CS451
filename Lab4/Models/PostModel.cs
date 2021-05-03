using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class PostModel
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public UserModel Author { get; set; }
        public string Image { get; set; }
        public List<UserModel> Likes { get; set; }
    }
}
