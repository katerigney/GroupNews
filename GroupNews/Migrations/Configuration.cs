namespace GroupNews.Migrations
{
    using System;
    using GroupNews.Models;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<GroupNews.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GroupNews.Data.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

             var categories = new List<Category>
             {
                 new Category
                 {
                     Name = "Florida Man"
                 },

                 new Category
                 {
                     Name = "Pets"
                 },

                 new Category
                 {
                     Name = "Missed Connections"
                 }
             };

            foreach(var category in categories)
            {
                context.Categories.AddOrUpdate(x => x.Name, category);

            }

            var users = new List<User>
            {
                new User {UserName = "James E."},
                new User {UserName = "Britney D."},
                new User {UserName = "Kate R."},
                new User {UserName = "Mark D."},
                new User {UserName = "Chris T."},
                new User {UserName = "Darlene S."}
            };

            foreach(var user in users)
            {
                context.Users.AddOrUpdate(x => x.UserName, user);
            }

            var stories = new List<Story>
            {
                new Story
                {
                    Headline = "Florida Man attempts to smoke crack in ICU, almost burns down hospital. ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 1, User = users[0]
                },
                new Story
                {
                    Headline = "Florida Man flashes buttocks at IHOP after impersonating a police officer to get free food. ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse feliper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelers eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 1, User = null
                },
                new Story
                {
                    Headline = "Florida Man bites off neighbor's ear because he wouldn't give him a cigarette.",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 1, User = users[2]
                },
                new Story
                {
                    Headline = "Florida man claims wife was kidnapped by holograms. ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 1, User = null
                },
                new Story
                {
                    Headline = "Drunk Florida Man attempts to ride bike through Taco Bell drive-thru, fights with police ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 1, User = null
                },
                new Story
                {
                    Headline = "Do Dogs Dream?  ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 2, User = users[4]
                },
                new Story
                {
                    Headline = "5 “Silent” Killers of Cats ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 2, User = users[1]
                },
                new Story
                {
                    Headline = "Do Cats really love you less than dogs? ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 2, User = users[3]
                },
                new Story
                {
                    Headline = "5 Reasons to test your dog for Diabetes ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 2, User = users[2]
                },
                new Story
                {
                    Headline = "Wintering with Horses ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 2, User = null
                },
                new Story
                {
                    Headline = "Straz Center elevator  ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 3, User = null
                },
                new Story
                {
                    Headline = "I saw you on Bayshore  ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 3, User = null
                },
                new Story
                {
                    Headline = "Blonde Lady at Winn-Dixxie on 4th Street ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 3, User = null
                },
                new Story
                {
                    Headline = "Pho Better or Pho Worse ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 3, User = null
                },
                new Story
                {
                    Headline = "Wintering with Horses ",
                    BodyContent = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin viverra " +
                    "arcu vitae dolor faucibus, ac maximus turpis dictum. Nullam blandit est quis nibh egestas" +
                    " rutrum. Donec scelerisque pellentesque metus ultricies commodo. Sed iaculis felis et " +
                    "metus viverra bibendum. Duis nisl elit, volutpat non interdum sed, ultricies eu mauris. " +
                    "Donec et semper turpis, luctus imperdiet dolor. Phasellus at lacus at elit congue elementum. " +
                    "Suspendisse felis eros, commodo vitae arcu eu, feugiat maximus urna. Quisque a ullamcorper sem." +
                    " Mauris ullamcorper diam ipsum, ac dignissim ligula consequat sit amet. Quisque tincidunt justo " +
                    "vel metus eleifend, at commodo nisi efficitur. In finibus nisl non risus suscipit, mattis dignissim " +
                    "purus vehicula. Nulla pharetra turpis eu magna congue porta. Praesent quam massa, vehicula ut nulla ut, " +
                    "euismod scelerisque tortor. Morbi tempor nec orci in malesuada.",
                     CategoryID = 3, User = users[5]
                }
            };

            foreach (var story in stories)
            {
                context.Stories.AddOrUpdate(x => x.Headline, story);
            }

            context.SaveChanges();
        }

         
    }
}
