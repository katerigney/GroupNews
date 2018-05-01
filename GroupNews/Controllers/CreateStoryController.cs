using GroupNews.Data;
using GroupNews.Models;
using GroupNews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace GroupNews.Controllers
{
    public class CreateStoryController : ApiController
    {

        [HttpPost]
        [Route("api/createStory")]
        public IHttpActionResult PostStory([FromBody]CreateStoryViewModel data)
        {
            using (var db = new DataContext())
            {
                var ViewStories = db.Stories.Include(i => i.User).Include(i => i.Category);

                var thisAuthor = db.Users.SingleOrDefault(s => s.UserName == data.UserName);
                var thisCategory = db.Categories.SingleOrDefault(s => s.Name == data.Category);

       
                if (thisCategory == null)
                {
                    thisCategory = new Category
                    {
                        Name = data.Category
                    };
                    db.Categories.Add(thisCategory);
                    db.SaveChanges();
                }

                var newStory = new Story
                {
                    Headline = data.Headline,
                    BodyContent = data.BodyContent,
                    Timestamp = DateTime.Now,
                    
                    UserID = thisAuthor?.ID,

                    Category = thisCategory
                };

                db.Stories.Add(newStory);
                db.SaveChanges();

                return Ok(newStory);
            }
        }
    }
}
