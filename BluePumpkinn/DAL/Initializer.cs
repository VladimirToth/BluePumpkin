using BluePumpkinn.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BluePumpkinn.DAL
{
    public class Initializer:DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var eventType = new List<EventType>{
                new EventType{TypeName="Meeting" },
                new EventType{TypeName="Game" },
                new EventType{TypeName="Competition" },
            };
            eventType.AddRange(context.EventType);
            context.SaveChanges();

            //var allEvents=new List<Event>{
            //    new Event{
            //        Name="Event1",
            //        EventDate=DateTime.Parse("2005-09-01"),
            //        EventLocation="Westminster BC",
                    
            //        Description="Commission invites charities, trustees and their advisers to attend its Annual Public Meeting on 15 December 2015. The meeting will be chaired by William Shawcross, chairman of the Charity Commission, who will also open the meeting. Attendees will then hear from the regulator’s new Chief Executive, Paula Sussex, on the Commission’s work over the last year and her plans for the coming months. The meeting will also include a lecture from the renowned historian and author Dr Frank Prochaska on ‘The State of Charity’. Dr Prochaska, a former lecturer in British history at Yale, will also invite attendees to comment and discuss the topic."
            //};

            //allEvents.AddRange(context.Event);
            //context.SaveChanges();
            //base.Seed(context);
        }
    }
}