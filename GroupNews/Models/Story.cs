using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupNews.Models
{
    public class Story
    {
        public int ID { get; set; }
        public string Headline { get; set; }
        public string BodyContent { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        public int UserID { get; set; }
        public User Author { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}