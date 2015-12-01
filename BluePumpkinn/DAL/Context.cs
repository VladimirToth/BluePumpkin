using BluePumpkinn.Models;
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

        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventParticipant> EventParticipant { get; set; }

    }
}