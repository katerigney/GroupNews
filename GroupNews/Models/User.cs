using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupNews.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; } = "Anonymous";

        ICollection<Story> Submissions { get; set; } = new HashSet<Story>();
    }
}