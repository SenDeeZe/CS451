using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public List<UserModel> Subscriptions { get; set; }
        public List<UserModel> Subcscribers { get; set; }
        public string Image { get; set; }
        public string Bio { get; set; }
    }
}
