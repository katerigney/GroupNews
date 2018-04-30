using GroupNews.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroupNews.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Story> Stories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}