namespace ZenithWebSite.Migrations.Identity
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ZenithDataLib.Models;
    using ZenithDataLib.Models.ZenithSociety;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithDataLib.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Identity";
        }

        protected override void Seed(ZenithDataLib.Models.ApplicationDbContext context)
        {
            context.Activities.AddOrUpdate(getActivities().ToArray());
            context.SaveChanges();

            context.Events.AddOrUpdate(e => e.EventId, getEvents(context).ToArray());
            context.SaveChanges();
        }
        private List<Activity> getActivities()
        {
            List<Activity> activities = new List<Activity>();
            activities.Add(new Activity()
            {
                ActivityDescription = "Senior's Golf Tournament",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Leadership General Assembly Meeting",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Youth Bowling Tournaments",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Young ladies cooking lessons",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Youth craft lessons",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Youth choir lessons",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Lunch",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Pancake Breakfast",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Swimming Lessons for the youth",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Swimming Exercise for parents",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Bingo Tournament",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "BBQ Lunch",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            activities.Add(new Activity()
            {
                ActivityDescription = "Garage Sale",
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00)
            });
            return activities;
        }

        private List<Event> getEvents(ApplicationDbContext db)
        {
            List<Event> events = new List<Event>();
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 09, 27, 08, 30, 00),
                ToDate = new DateTime(2016, 09, 27, 10, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Senior's Golf Tournament"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 09, 28, 08, 30, 00),
                ToDate = new DateTime(2016, 09, 28, 10, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Leadership General Assembly Meeting"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 09, 30, 17, 30, 00),
                ToDate = new DateTime(2016, 09, 30, 19, 15, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Youth Bowling Tournaments"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 09, 30, 19, 00, 00),
                ToDate = new DateTime(2016, 09, 30, 20, 00, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Young ladies cooking lessons"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 01, 08, 30, 00),
                ToDate = new DateTime(2016, 10, 01, 10, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Youth craft lessons"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 01, 10, 30, 00),
                ToDate = new DateTime(2016, 10, 01, 12, 00, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Youth choir lessons"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 01, 12, 00, 00),
                ToDate = new DateTime(2016, 10, 01, 13, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Lunch"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 07, 30, 00),
                ToDate = new DateTime(2016, 10, 02, 08, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Pancake Breakfast"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 08, 30, 00),
                ToDate = new DateTime(2016, 10, 02, 10, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Swimming Lessons for the youth"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 08, 30, 00),
                ToDate = new DateTime(2016, 10, 02, 10, 30, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Swimming Exercise for parents"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 10, 30, 00),
                ToDate = new DateTime(2016, 10, 02, 12, 00, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Bingo Tournament"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 12, 00, 00),
                ToDate = new DateTime(2016, 10, 02, 13, 00, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "BBQ Lunch"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });
            events.Add(new Event()
            {
                FromDate = new DateTime(2016, 10, 02, 13, 00, 00),
                ToDate = new DateTime(2016, 10, 02, 16, 00, 00),
                Activity = db.Activities.First(a => a.ActivityDescription == "Garage Sale"),
                ApplicationUser = db.Users.First(a => a.UserName == "a"),
                CreationDate = new DateTime(2016, 09, 20, 11, 30, 00),
                IsActive = true
            });

            return events;
        }
    }
}
