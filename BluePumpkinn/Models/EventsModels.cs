using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BluePumpkinn.Models
{
    public class EventParticipant
    {
        public int ID { get; set; }
        public int ApplicationUserID { get; set; }
        public int EventID { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<Event> Event { get; set; }

    }


    public class Event
    {
        [Required(ErrorMessage = "Please enter the ID for the event!")]
        public int ID { get; set; } 

        [Required(ErrorMessage = "Please enter the name for the event!")]
        [DisplayName("Event Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the date at which event will occur!")]
        [DisplayName("Event Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage = "Please enter the location for the event!")]
        [DisplayName("Event Location")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Please type a desription for this event!")]
        [DisplayName("Description of event")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public int EventParticipantID { get; set; }

        public virtual ICollection<EventParticipant> EventParticipant { get; set; }
    }

    public class EventsModels
    {
        [ScaffoldColumn(false)]
        public long EventId { get; set; }

        [Required(ErrorMessage = "Please enter the name for the event!")]
        [DisplayName("Event Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the date at which event will occur!")]
        [DisplayName("Event Date")]
        public DateTime EventDate { get; set; }

        [Required(ErrorMessage ="PLease enter the location for the event!")]
        [DisplayName("Event Location")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Please enter your name as event founder!")]
        [DisplayName("Event Founder")]
        public string EventFounder { get; set; }

        [Required(ErrorMessage = "Please type a desription for this event!")]
        [DisplayName("Description of event")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please add your foto!")]
        public string EventFounderFoto { get; set; }
    }
}