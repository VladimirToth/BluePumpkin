using BluePumpkinn.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BluePumpkinn.DAL
{
    public class Context:DbContext
    {
        public Context()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Event> Event { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<EventParticipant> EventParticipant { get; set; }

    }
}