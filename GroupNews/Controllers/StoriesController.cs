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

                var results = latestStoriesQuery.ToList();

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
    }
}