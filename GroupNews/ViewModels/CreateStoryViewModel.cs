using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupNews.ViewModels
{
    public class CreateStoryViewModel
    {
        public string Headline { get; set; }
        public string BodyContent { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;

        public string UserName { get; internal set; }
        public string Category { get; internal set; }
    }
}
