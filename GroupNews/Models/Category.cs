using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupNews.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        ICollection<Story> Submissions { get; set; } = new HashSet<Story>();
    }
}