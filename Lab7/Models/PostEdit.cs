using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab7.Models
{
    public class PostEdit
    {
        public string UserId { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }

        public PostEdit()
        {
            Text = "";
            Image = "";
        }
    }
}
