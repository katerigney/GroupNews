using GroupNews.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroupNews.Controllers
{
    public class StoriesController : ApiController
    {
        public IHttpActionResult Get()
        {
            using (var db = new DataContext())
            {
                var latestStoriesQuery = db.Stories.Include(i => i.User).Include(i => i.Category);

                var results = latestStoriesQuery.OrderBy(o => o.Timestamp).ToList();

                if (results == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(results);
                }
            }
        }

        [HttpGet]
        public IHttpActionResult GetOneStory(int id)
        {
            using (var db = new DataContext())
            {
                var query = db.Stories
                    .Include(i => i.Category)
                    .Include(i => i.User)
                    .SingleOrDefault(s => s.ID == id);
                if (query == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(query);
                }
            }
        }
    }
}